/************************************************************************************************
 * SwiftlyS2 is a scripting framework for Source2-based games.
 * Copyright (C) 2025 Swiftly Solution SRL via Sava Andrei-Sebastian and it's contributors
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 ************************************************************************************************/

#ifndef src_server_translations_translations_h
#define src_server_translations_translations_h

#include <api/server/translations/translations.h>

#include <map>

class CTranslations : public ITranslations
{
public:
    virtual void Initialize() override;
    virtual void ClearTranslations() override;
    virtual void LoadTranslations() override;
    virtual void LoadTranslationFile(const std::string& file) override;
    virtual std::string FetchTranslation(const std::string& key, int playerid) override;
private:
    std::map<std::string, std::map<std::string, std::string>> m_mTranslations;
};

#endif