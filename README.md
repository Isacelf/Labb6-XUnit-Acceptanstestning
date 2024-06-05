## Acceptanstest

### Acceptanstest 1: Addition
**Användarinstruktioner:**
1. Öppna räknemaskinsapplikationen.
2. Välj Addition genom att ange 1.
3. Mata in det första talet (t.ex. 4).
4. Mata in det andra talet (t.ex. 6).
5. Tryck på Enter.

**Förväntat resultat:**
- Applikationen ska visa "Summan är: 10."
- Beräkningen "4 + 6 = 10" ska sparas i historiken.

### Acceptanstest 2: Subtraktion
**Användarinstruktioner:**
1. Öppna räknemaskinsapplikationen.
2. Välj Subtraktion genom att ange 2.
3. Mata in det första talet (t.ex. 10).
4. Mata in det andra talet (t.ex. 4).
5. Tryck på Enter.

**Förväntat resultat:**
- Applikationen ska visa "Differensen är: 6."
- Beräkningen "10 - 4 = 6" ska sparas i historiken.

### Acceptanstest 3: Division med noll
**Användarinstruktioner:**
1. Öppna räknemaskinsapplikationen.
2. Välj Division genom att ange 4.
3. Mata in det första talet (t.ex. 55,5).
4. Mata in det andra talet (t.ex. 0).
5. Tryck på Enter.

**Förväntat resultat:**
- Applikationen ska visa resultatet 0, då det inte går att dela med 0.
- Beräkningen "55,5 / 0 = Kan inte dela med noll." ska sparas i historiken.

## Enhetstester

Enhetstesterna finns implementerade med XUnit och testar olika delar av applikationen. Se CalculatorXUnitTests.cs för mer detaljer.
