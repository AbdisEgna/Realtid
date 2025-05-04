# Naturliga växter & kreativa trädgårdar

I detta projekt har Åsa velat ha en webapp för sitt projekt med specifika krav som fokuserar på att förbättra kommunikationen med kunder och hantering av sina växthus. Lösningen måste vara realtidsbaserade med uppdateringar utan att användaren behöver ladda om sidan. Jag har därmed valt två av de föreslagna idéerna som ska implementeras.

# De valda funktionerna
Chattfunktion för kunder för att förbättra kommunikationen med kunderna. Kunden kommer kunna skicka och få meddelanden direkt från Åsa i realtid.
**Teknik:** SignalR används för att hantera realtids meddelanden. Jag har även valt att tillägga funktionen av att inte använda databaslagring eftersom fokuset blir snabb och enkel kommunikation.

# Väderprognos
Eftersom att växthusmiljön är en viktig aspekt så har jag valt att implementera funktionen direkt i webappen.
**Teknik:** Väderdata hämtas från ett externt API för att hämta väderdata från en väderleverantör och uppdateras med hjälp av SignalR. Funktionen blir då att prognosen visas somen enkel komponent för en snabb överblick.

# Kanban 
<img width="955" alt="Kanban" src="https://github.com/user-attachments/assets/1fe8abfb-27cb-4c6f-a717-844d7917fdd7">

# Wireframe 
<img width="375" alt="väder" src="https://github.com/user-attachments/assets/dbc3650b-64d5-4e96-962c-7e5ad518e1c0">
<img width="377" alt="chatt" src="https://github.com/user-attachments/assets/89652110-b9a3-40c7-b05b-d77b1daddae9">

# Use Case 
<img width="238" alt="Use Case" src="https://github.com/user-attachments/assets/247419bd-5b0e-48b4-b3c4-c4230619215f">
