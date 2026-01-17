# Udhëzime për Marrjen dhe Ekzekutimin e Projektit
## Visual Studio 2022

Ky dokument shpjegon hapat që duhen ndjekur për të marrë projektin nga GitHub, për ta konfiguruar dhe për ta ekzekutuar në **Visual Studio 2022**.

---

## 1. Kërkesat Paraprake
- Visual Studio 2022 (Community / Professional / Enterprise)
- Git (instalohet automatikisht nga Visual Studio nëse mungon)
- Databazë funksionale (sipas projektit: SQL Server / PostgreSQL / etj.)

---

## 2. Marrja e Projektit nga GitHub

### Opsioni A: Clone direkt nga Visual Studio 2022 (e rekomanduar)
1. Hapni **Visual Studio 2022**
2. Zgjidhni **File → Clone Repository**
3. Vendosni linkun e projektit nga GitHub:
4. Zgjidhni vendndodhjen në kompjuterin tuaj
5. Klikoni **Clone**
6. Nëse projekti nuk hapet automatikisht, hapni manualisht file-in `.sln`

## 3. Konfigurimi i Aplikacionit (`appsettings.json`)

Përpara se të ekzekutoni aplikacionin, është e domosdoshme të konfiguroni lidhjen me databazën.

### Hapat që duhen ndjekur:
1. Hapni file-in `appsettings.json`
2. Gjeni seksionin `ConnectionStrings`
3. Përditësoni vlerat sipas ambientit tuaj (lokal ose server)

### Shembull konfigurimi:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SERVER_NAME;Database=DB_NAME;User Id=USERNAME;Password=PASSWORD;"
}

