﻿using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

public enum NetChannelBufType_t: sbyte
{
    BUF_DEFAULT = -1,
    BUF_UNRELIABLE = 0,
    BUF_RELIABLE,
    BUF_VOICE,
};

[StructLayout(LayoutKind.Sequential)]
public struct CRecipientFilter
{
    private nint _pVTable;
    public ulong RecipientsMask;
    public NetChannelBufType_t BufferType;
    public bool InitMessage;

    public CRecipientFilter(NetChannelBufType_t BufType = NetChannelBufType_t.BUF_RELIABLE, bool bInitMessage = false)
    {
        _pVTable = CRecipientFilterVtable.pCRecipientFilterVTable;
        RecipientsMask = 0;
        InitMessage = bInitMessage;
        BufferType = BufType;
    }

    public static CRecipientFilter FromMask(ulong playerMask)
    {
        CRecipientFilter filter = new();
        filter.RecipientsMask = playerMask;
        return filter;
    }

    public static CRecipientFilter FromPlayers(params int[] players)
    {
        CRecipientFilter filter = new();
        foreach (int player in players) {
            filter.AddRecipient(player);
        }
        return filter;
    }

    public static CRecipientFilter FromSingle(int player)
    {
        CRecipientFilter filter = new();
        filter.AddRecipient(player);
        return filter;
    }

    public ulong ToMask()
    {
        return RecipientsMask;
    }

    public void AddAllPlayers()
    {
        RecipientsMask = 0xFFFFFFFFFFFFFFFF;
        // @todo: When playermanager will be implemeneted, iterate through all the 64 players and if they're online and are authorized, add them here
    }

    public void RemoveAllPlayers()
    {
        RecipientsMask = 0;
    }

    public void AddRecipient(int playerid)
    {
        if (playerid < 0 || playerid > 63) throw new IndexOutOfRangeException("PlayerID out of range (0-63).");

        RecipientsMask |= 1UL << playerid;
    }

    public void RemoveRecipient(int playerid)
    {
        if (playerid < 0 || playerid > 63) throw new IndexOutOfRangeException("PlayerID out of range (0-63).");

        RecipientsMask &= ~(1UL << playerid);
    }

    public int GetRecipientCount()
    {
        int count = 0;
        for (int i = 0; i < 64; i++) {
            if ((RecipientsMask & (1UL << i)) != 0) {
                count++;
            }
        }
        return count;
    }
}

internal static class CRecipientFilterVtable {

    public static nint pCRecipientFilterVTable;

    [UnmanagedCallersOnly]
    public unsafe static void Destructor(CRecipientFilter* filter) {
        // do nothing
    }

    [UnmanagedCallersOnly]
    public unsafe static NetChannelBufType_t GetNetworkBufType(CRecipientFilter* filter) {
        return filter->BufferType;
    }

    [UnmanagedCallersOnly]
    public unsafe static bool IsInitMessage(CRecipientFilter* filter) {
        return filter->InitMessage;
    }

    [UnmanagedCallersOnly]
    public unsafe static ulong* GetRecipients(CRecipientFilter* filter) {
        return &filter->RecipientsMask;
    }

    static unsafe CRecipientFilterVtable() {
        pCRecipientFilterVTable = Marshal.AllocHGlobal(sizeof(nint) * 4);
        Span<nint> vtable = new((void*)pCRecipientFilterVTable, 4);
        vtable[0] = (nint)(delegate* unmanaged<CRecipientFilter*, void>)(&Destructor);
        vtable[1] = (nint)(delegate* unmanaged<CRecipientFilter*, NetChannelBufType_t>)(&GetNetworkBufType);
        vtable[2] = (nint)(delegate* unmanaged<CRecipientFilter*, bool>)(&IsInitMessage);
        vtable[3] = (nint)(delegate* unmanaged<CRecipientFilter*, ulong*>)(&GetRecipients);
    }
}