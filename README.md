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
![image](https://github.com/user-attachments/assets/f43789fc-5c0c-4e55-b1e8-03088074f947)
![image](https://github.com/user-attachments/assets/7eb73f4f-a161-495c-853a-957f381d13c9)

# Use Case 
<img width="238" alt="Use Case" src="https://github.com/user-attachments/assets/247419bd-5b0e-48b4-b3c4-c4230619215f">
