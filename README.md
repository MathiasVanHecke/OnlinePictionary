# OnlinePictionary
## Wat
Een online tekenspel waar de kandidaten het getekend woord moet raden voor punten.

## Wat is er live?
- Het canvas van de tekening.
- De live-chat waar de kanidaten het woord moeten raden.
- De score van de spelers.

# Checklist
## Backend
[ ] Backend API: Is een C# API (level 2) die zowel via website of mobiel kan bevraagd worden, zonder dat hiervoor veel code moet herschreven worden.

[ ] De database: Gegevens worden persistent gestockeerd in MSSQL, MySQL en/of MongoDb.

[ ] Realtime: Wordt gerealiseerd op basis van websockets.

[ ] Autorisatie en authenticatie: Gebeurt met JWT of IdentityServer4.

[ ] Kwetsbaarheid: CORS is enabled met een maximale beveiliging tegen crosssite scripting. 

[ ] API docs: De API documenteert zichzelf op basis van een selfdocumenting library.

[ ] Framework: Gebruik van het EntityFramework. Via een seeder verloopt de installatie van de MVC backend automatisch op een lokale PC.

[ ] Foutcontrole: Het crashen van de applicatie wordt verhinderd door het gebruik van een logger in try/catch structuur.

[ ] Source controle: Source controle gebeurt via GitHub. Versiebeheer mag (moet niet) opgenomen zijn in de applicatie maar kan/mag evengoed via GitHub branches.

[ ] Deployment Docker: enabled op een omgeving naar keuze, indien praktisch haalbaar (Azure,Heroku)

## Frontend
[ ] Framework: Met een JS framework gemaakt; Vue.js, Angular of React. Werk met components, gebruik de state management van het framework.

[ ] Testing: Er zijn minstens een unit en een integration test.

[ ]Styling: Je werkt met SCSS met een achterliggende structuur.

[ ] PWA: De web app kan fullscreen launchen en heeft een correcte PWA-setup.

[ ] Multi-language: De applicatie meertalig maken kan zeker een meerwaarde zijn. Indien je dit op een goede manier uitwerkt, kan dit zeker extra punten opleveren.

[ ] Error Logging: Het is een meerwaarde om fouten te loggen

[ ] Development setup: ebruik van https://codeclimate.com/ voor code testing en reviews is een meerwaarde

[ ] Optimisation :Gebruik webpack voor een betere JS files delivery.

# Extra inbreng
## Backend
- Gebruik van groepen in Signal R

## Frontend
- Het gebruik maken van canvas
- De event bus  gebruiken in vue: $emit & $on
- Doorsturen van parms in linken naar een andere pagina
