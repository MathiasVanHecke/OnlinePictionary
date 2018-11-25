# OnlinePictionary
## Wat
Een online tekenspel waar de kandidaten het getekend woord moet raden voor punten.

## Wat is er live?
- Het canvas van de tekening.
- De live-chat waar de kanidaten het woord moeten raden.
- De score van de spelers.
- De wachtkamer waar de mensen komen voor het spel gestart wordt.

# Checklist
## Backend
[X] Backend API: is een C# API (level 2) die zowel via website of mobiel kan bevraagd worden, zonder dat hiervoor veel code moet herschreven worden.

[X] De database: gegevens worden persistent gestockeerd in MSSQL, MySQL en/of MongoDb.

[X] Realtime: wordt gerealiseerd op basis van websockets.

[X] Autorisatie en authenticatie: gebeurt met JWT of IdentityServer4.

[X] Kwetsbaarheid: CORS is enabled met een maximale beveiliging tegen crosssite scripting. 

[X] API docs: de API documenteert zichzelf op basis van een selfdocumenting library.

[ ] Framework: gebruik van het EntityFramework. Via een seeder verloopt de installatie van de MVC backend automatisch op een lokale PC.

[ ] Foutcontrole: het crashen van de applicatie wordt verhinderd door het gebruik van een logger in try/catch structuur.

[X] Source controle: source controle gebeurt via GitHub. Versiebeheer mag (moet niet) opgenomen zijn in de applicatie maar kan/mag evengoed via GitHub branches.

[X] Deployment Docker: enabled op een omgeving naar keuze, indien praktisch haalbaar (Azure,Heroku)

## Frontend
[X] Framework: met een JS framework gemaakt; Vue.js, Angular of React. Werk met components, gebruik de state management van het framework.

[ ] Testing: er zijn minstens een unit en een integration test.

[X] Styling: je werkt met SCSS met een achterliggende structuur.

[X] PWA: de web app kan fullscreen launchen en heeft een correcte PWA-setup.

[X] Multi-language: de applicatie meertalig maken kan zeker een meerwaarde zijn. Indien je dit op een goede manier uitwerkt, kan dit zeker extra punten opleveren.

[ ] Error Logging: het is een meerwaarde om fouten te loggen

[ ] Development setup: gebruik van https://codeclimate.com/ voor code testing en reviews is een meerwaarde

[X] Optimisation: gebruik webpack voor een betere JS files delivery.

# Extra inbreng
## Backend
- Gebruik van groepen in Signal R

## Frontend
- Het gebruik maken van canvas
- De event bus  gebruiken in vue: $emit & $on
- Doorsturen van parms in linken naar een andere pagina
