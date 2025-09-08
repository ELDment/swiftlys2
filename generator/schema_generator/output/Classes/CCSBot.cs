using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSBot : CBot, ICSBot {

  public CCSBot(nint handle) : base(handle) {
  }

  public ref Vector EyePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D847A3605));
  }
  public ISchemaFixedString Name {
    get => new SchemaFixedString(_Handle, 0x1CFE165D4D8F5786, 64, 1, 1);
  }
  public ref float CombatRange {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D7FF44CAE));
  }
  public ref bool IsRogue {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165DE8EBF51D));
  }
  public ICountdownTimer RogueTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D9929D03A));
  }
  public ref bool DiedLastRound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D7918194D));
  }
  public ref float SafeTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DCD4F2CB1));
  }
  public ref bool WasSafe {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D6A526C0F));
  }
  public ref bool BlindFire {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D5C84B7B8));
  }
  public ICountdownTimer SurpriseTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165DA36B5C8B));
  }
  public ref bool AllowActive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165DED9989D4));
  }
  public ref bool IsFollowing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D985B15A8));
  }
  public ref CHandle<CCSPlayerPawn> Leader {
    get => ref _Handle.AsRef<CHandle<CCSPlayerPawn>>(Schema.GetOffset(0x1CFE165D658B4E84));
  }
  public ref float FollowTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DDF9139C0));
  }
  public ref float AllowAutoFollowTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DA781FC01));
  }
  public ICountdownTimer HurryTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165DFDAD0CF6));
  }
  public ICountdownTimer AlertTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165DCF6A9726));
  }
  public ICountdownTimer SneakTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D90AB3A2C));
  }
  public ICountdownTimer PanicTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165DD2FFC665));
  }
  public ref float StateTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D5C65DB5E));
  }
  public ref bool IsAttacking {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D4115CA53));
  }
  public ref bool IsOpeningDoor {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D75EC227F));
  }
  public ref CHandle<CBaseEntity> TaskEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1CFE165DF6C25037));
  }
  public ref Vector GoalPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D02ACD9A1));
  }
  public ref CHandle<CBaseEntity> GoalEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1CFE165D7C389945));
  }
  public ref CHandle<CBaseEntity> Avoid {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1CFE165D6F622DBE));
  }
  public ref float AvoidTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D6D375DA6));
  }
  public ref bool IsStopping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165DD9004179));
  }
  public ref bool HasVisitedEnemySpawn {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D37ADF7A0));
  }
  public IIntervalTimer StillTimer {
    get => new IntervalTimer(_Handle + Schema.GetOffset(0x1CFE165D2772246E));
  }
  public ref bool EyeAnglesUnderPathFinderControl {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165DA5BDDE74));
  }
  public ref int PathIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165D1475A65A));
  }
  public IGameTime_t AreaEnteredTimestamp {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1CFE165D024F57F1));
  }
  public ICountdownTimer RepathTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D4AEA977C));
  }
  public ICountdownTimer AvoidFriendTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D71F4289B));
  }
  public ref bool IsFriendInTheWay {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165DF84E085C));
  }
  public ICountdownTimer PoliteTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D2C92F065));
  }
  public ref bool IsWaitingBehindFriend {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D8D7CD63C));
  }
  public ref float PathLadderEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D1850F03B));
  }
  public ICountdownTimer MustRunTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D45DDFB8A));
  }
  public ICountdownTimer WaitTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D65FC5371));
  }
  public ICountdownTimer UpdateTravelDistanceTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D67E5EA78));
  }
  public ISchemaFixedArray<float> PlayerTravelDistance {
    get => new SchemaFixedArray<float>(_Handle, 0x1CFE165DA4B8EEEF, 64, 4, 4);
  }
  public ref byte TravelDistancePhase {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1CFE165D1572AE9D));
  }
  public ref byte HostageEscortCount {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1CFE165DE7DC72ED));
  }
  public ref float HostageEscortCountTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D52FB244B));
  }
  public ref int DesiredTeam {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165D4C27289C));
  }
  public ref bool HasJoined {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D267EC342));
  }
  public ref bool IsWaitingForHostage {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D964A1230));
  }
  public ICountdownTimer InhibitWaitingForHostageTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D12E79190));
  }
  public ICountdownTimer WaitForHostageTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D2BFAE489));
  }
  public ref Vector NoisePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D95F59336));
  }
  public ref float NoiseTravelDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DFBC52452));
  }
  public ref float NoiseTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D59D7AE8F));
  }
  public ICSPlayerPawn NoiseSource {
    get => new CCSPlayerPawn(_Handle + Schema.GetOffset(0x1CFE165D6FD60BAC));
  }
  public ICountdownTimer NoiseBendTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D0106074F));
  }
  public ref Vector BentNoisePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165DFC0A8717));
  }
  public ref bool BendNoisePositionValid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165DD2E17F63));
  }
  public ref float LookAroundStateTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DBB8E8FEC));
  }
  public ref float LookAheadAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DE1B3AC72));
  }
  public ref float ForwardAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D1EA773D9));
  }
  public ref float InhibitLookAroundTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D42052B3A));
  }
  public ref Vector LookAtSpot {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D979DCA7B));
  }
  public ref float LookAtSpotDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D4E0E35DF));
  }
  public ref float LookAtSpotTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DD82BB759));
  }
  public ref float LookAtSpotAngleTolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D35DB2DF5));
  }
  public ref bool LookAtSpotClearIfClose {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D785CD9B9));
  }
  public ref bool LookAtSpotAttack {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D89782103));
  }
  public ref CString LookAtDesc {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x1CFE165D1BCD290E));
  }
  public ref float PeripheralTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DEABBC23F));
  }
  public ref byte ApproachPointCount {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1CFE165DBB4E85C4));
  }
  public ref Vector ApproachPointViewPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D0EBE87BB));
  }
  public IIntervalTimer ViewSteadyTimer {
    get => new IntervalTimer(_Handle + Schema.GetOffset(0x1CFE165D634A52D7));
  }
  public ICountdownTimer TossGrenadeTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165DB6FBFF99));
  }
  public ICountdownTimer IsAvoidingGrenade {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D3ACC70E8));
  }
  public ref float SpotCheckTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D2B46BE5D));
  }
  public ref int CheckedHidingSpotCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165D7C1B90E0));
  }
  public ref float LookPitch {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D9D64CEC4));
  }
  public ref float LookPitchVel {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D35CDA5BF));
  }
  public ref float LookYaw {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D84569319));
  }
  public ref float LookYawVel {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D66FBE00C));
  }
  public ref Vector TargetSpot {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D322B2410));
  }
  public ref Vector TargetSpotVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D08431D43));
  }
  public ref Vector TargetSpotPredicted {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D32A95D44));
  }
  public ref QAngle AimError {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1CFE165DB9ECC560));
  }
  public ref QAngle AimGoal {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1CFE165DB293A8E9));
  }
  public IGameTime_t TargetSpotTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1CFE165DFAA023C9));
  }
  public ref float AimFocus {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DE49DD71A));
  }
  public ref float AimFocusInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D0D347F6F));
  }
  public IGameTime_t AimFocusNextUpdate {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1CFE165D171BF4E6));
  }
  public ICountdownTimer IgnoreEnemiesTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165DCFC4C322));
  }
  public ref CHandle<CCSPlayerPawn> Enemy {
    get => ref _Handle.AsRef<CHandle<CCSPlayerPawn>>(Schema.GetOffset(0x1CFE165DD63838CB));
  }
  public ref bool IsEnemyVisible {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D0457F7FF));
  }
  public ref byte VisibleEnemyParts {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1CFE165DA37281F3));
  }
  public ref Vector LastEnemyPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165DB47A1A44));
  }
  public ref float LastSawEnemyTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D0F06E8FA));
  }
  public ref float FirstSawEnemyTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D66361312));
  }
  public ref float CurrentEnemyAcquireTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D05FE4C96));
  }
  public ref float EnemyDeathTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D49A3954D));
  }
  public ref float FriendDeathTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DC6A37F13));
  }
  public ref bool IsLastEnemyDead {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D12BA73F1));
  }
  public ref int NearbyEnemyCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165DE4C9C125));
  }
  public ref CHandle<CCSPlayerPawn> Bomber {
    get => ref _Handle.AsRef<CHandle<CCSPlayerPawn>>(Schema.GetOffset(0x1CFE165D1F24BFCA));
  }
  public ref int NearbyFriendCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165D268D2385));
  }
  public ref CHandle<CCSPlayerPawn> ClosestVisibleFriend {
    get => ref _Handle.AsRef<CHandle<CCSPlayerPawn>>(Schema.GetOffset(0x1CFE165DF41BB33A));
  }
  public ref CHandle<CCSPlayerPawn> ClosestVisibleHumanFriend {
    get => ref _Handle.AsRef<CHandle<CCSPlayerPawn>>(Schema.GetOffset(0x1CFE165D37571CF3));
  }
  public IIntervalTimer AttentionInterval {
    get => new IntervalTimer(_Handle + Schema.GetOffset(0x1CFE165D90537394));
  }
  public ref CHandle<CCSPlayerPawn> Attacker {
    get => ref _Handle.AsRef<CHandle<CCSPlayerPawn>>(Schema.GetOffset(0x1CFE165D3CB57DEE));
  }
  public ref float AttackedTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165DC2564304));
  }
  public IIntervalTimer BurnedByFlamesTimer {
    get => new IntervalTimer(_Handle + Schema.GetOffset(0x1CFE165D399D4DA9));
  }
  public ref int LastVictimID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165D8033F8F4));
  }
  public ref bool IsAimingAtEnemy {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D0D99047D));
  }
  public ref bool IsRapidFiring {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165DDE4888E6));
  }
  public IIntervalTimer EquipTimer {
    get => new IntervalTimer(_Handle + Schema.GetOffset(0x1CFE165D1E504868));
  }
  public ICountdownTimer ZoomTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D690C50D3));
  }
  public IGameTime_t FireWeaponTimestamp {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1CFE165D458E6273));
  }
  public ICountdownTimer LookForWeaponsOnGroundTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D1A0D7A39));
  }
  public ref bool IsSleeping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D360BFBD0));
  }
  public ref bool IsEnemySniperVisible {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165DC7EE90F2));
  }
  public ICountdownTimer SawEnemySniperTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165DBB2E748A));
  }
  public ref byte EnemyQueueIndex {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1CFE165D9D0C9CAE));
  }
  public ref byte EnemyQueueCount {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1CFE165D8187FF91));
  }
  public ref byte EnemyQueueAttendIndex {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1CFE165D0E18846A));
  }
  public ref bool IsStuck {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE165D24C49E9B));
  }
  public IGameTime_t StuckTimestamp {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1CFE165D1B5BADA9));
  }
  public ref Vector StuckSpot {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D0E386143));
  }
  public ICountdownTimer WiggleTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165DEDBA9421));
  }
  public ICountdownTimer StuckJumpTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1CFE165D1C8E034C));
  }
  public IGameTime_t NextCleanupCheckTimestamp {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1CFE165DB61EB6BC));
  }
  public ISchemaFixedArray<float> AvgVel {
    get => new SchemaFixedArray<float>(_Handle, 0x1CFE165D99077BFE, 10, 4, 4);
  }
  public ref int AvgVelIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165D17587BC2));
  }
  public ref int AvgVelCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165DF4550CBD));
  }
  public ref Vector LastOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D61FB608B));
  }
  public ref float LastRadioRecievedTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D382B6DA1));
  }
  public ref float LastRadioSentTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D7F5D6086));
  }
  public ref CHandle<CCSPlayerPawn> RadioSubject {
    get => ref _Handle.AsRef<CHandle<CCSPlayerPawn>>(Schema.GetOffset(0x1CFE165DF4F682DC));
  }
  public ref Vector RadioPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1CFE165D08071A87));
  }
  public ref float VoiceEndTimestamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE165D0035D346));
  }
  public ref int LastValidReactionQueueFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE165DA506BCCE));
  }


}