# Problem 1.More Exercises: Dictionaries and Lists

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions here: [https://judge.softuni.bg/Contests/582](https://judge.softuni.bg/Contests/582).

## Problem 1.Sort Times

Write a program, which receives a **list of times** (space-separated, 24-hour format) and **sorts** them in **ascending order**. Print the sorted times **comma-separated**.

Example: **06:55, 02:30, 23:11** ? **02:30, 06:55, 21:11**

### Examples

| **Input** | **Output** |
| --- | --- |
| 00:00 06:04 02:59 10:33 11:22 06:01 | 00:00, 02:59, 06:01, 06:04, 10:33, 11:22 |
| 04:25 04:21 04:19 | 04:19, 04:21, 04:25 |
| 00:00 23:59 12:00 16:00 | 00:00, 12:00, 16:00, 23:59 |

## Problem 2.Odd Filter

Write a program, which receives an array of **integers** (space-separated), **removes** all the odd numbers, then **converts** the remaining numbers to **odd numbers** , based on these conditions:

- If the number is **larger than** the **average** of the collection of remaining numbers, **add**** 1** to it.
- If the number is **smaller than** the **average** of the collection of remaining numbers, **subtract**** 1** from it.

After you convert all of the elements to odd numbers, **print** them on the console **(space-separated)**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 2 3 4 5 6 7 8 9 10 | 1 3 5 9 11 |
| 99 88 77 66 55 4 33 22 11 | 89 67 3 21 |
| 23 32 199 723 8127 95 | 31 |

## Problem 3.Immune System

An **organism** can encounter different types of **viruses**. It stores them in its **immune system**. If it has already encountered the virus, it fights it **faster** than if it hasn&#39;t encountered it yet.

The immune system can calculate the **virus&#39; strength** before it fights it. It is the **sum** of **all the virus name&#39;s letters&#39; ASCII codes, divided by 3**.

The immune system can also **calculate** the time it takes to **defeat** a **virus** in **seconds**. It is equal to the **virus strength, multiplied** by the **length** of the virus&#39; **name**.

When you calculate the **time to defeat** the virus, **convert** it to **minutes** and **seconds** (500 ? 8m 20s). **Do not** use any leading zeroes for the minutes and seconds.

The virus is **fought** according to **these conditions** :

- If the immune system **defeats** the virus, print:
&quot; **{virusName} defeated in {virusDefeatMinutes}m {virusDefeatSeconds}s.**&quot;
- If the virus&#39; strength is **more than** the **immune system&#39;s strength** , print &quot; **Immune System Defeated.**&quot; and exit the program.

After a virus is **defeated** , the **immune system** regains **20%** of its **strength**. If the 20 percent **exceeds** the **initial health** of the immune system, set it to the **initial health** instead.

Example: The virus &quot; **flu1**&quot;:

- Virus Strength: **102 (f) + 108 (l) + 117 (u) + 49 (1)** = **376 / 3** = **125.33 = 125**.
- Time to defeat: 125 \* 4 (virus name **length** ) = 500 seconds 8m 20s.

Example 2: Encountering &quot; **flu1**&quot; a **second time** :

- Time to defeat: **(125 \* 4) / 3** = **166.66**  **?**  **166 seconds**

If you encounter a virus any subsequent times, **do not** decrease its **time to defeat** further. When you receive the line &quot; **end**&quot;, print the status of the immune system in the format &quot; **Final Health: {finalHealth}**&quot;.

### Input

- First line: the **initial health** of the immune system
- On new lines, until you receive &quot; **end**&quot;: **virus names**

### Output

A **defeated** virus&#39; output looks like this:

- First line: &quot; **Virus {virusName}: {virusStrength} =&gt; {virusDefeatSeconds}**&quot;
- Second line: &quot; **{virusName} defeated in {defeatMins}m {defeatSecs}s.**&quot;
- Third line: &quot; **Remaining health: {remainingHealth}**&quot;. The remaining health is printed **before** its regeneration.

### Examples

| **Input** | **Output** |
| --- | --- |
| 5000flu1testflu1virusssssssend | Virus flu1: 125 =&gt; 500 secondsflu1 defeated in 8m 20s.Remaining health: 4500Virus test: 149 =&gt; 596 secondstest defeated in 9m 56s.Remaining health: 4404Virus flu1: 125 =&gt; 166 secondsflu1 defeated in 2m 46s.Remaining health: 4834Virus virusssssss: 419 =&gt; 4609 secondsvirusssssss defeated in 76m 49s.Remaining health: 391Final Health: 469 |
| 1750EbolaebolaEbolaend | Virus Ebola: 161 =&gt; 805 secondsEbola defeated in 13m 25s.Remaining health: 945Virus ebola: 171 =&gt; 855 secondsebola defeated in 14m 15s.Remaining health: 279Virus Ebola: 161 =&gt; 268 secondsEbola defeated in 4m 28s.Remaining health: 66Final Health: 79 |
| 5700wannacryiskaplachewannacry | Virus wannacry: 289 =&gt; 2312 secondswannacry defeated in 38m 32s.Remaining health: 3388Virus iskaplache: 348 =&gt; 3480 secondsiskaplache defeated in 58m 0s.Remaining health: 585Virus wannacry: 289 =&gt; 770 secondsImmune System Defeated. |

## Problem 4.Supermarket Database

Write a program, which keeps information about **products** and their **prices**. Each product has a **name** , a **price** and its **quantity**. If the product **doesn&#39;t exist** in the database yet, **add** it with its **starting quantity**.

If you receive a product, which **already exists** in the database, **increase** its quantity by the input quantity and if its **price** is different, **replace** the price as well.

You will receive products&#39; **names** , **prices** and **quantities** on **new lines**.Until you receive the command &quot; **stocked**&quot;, keep adding items to the database. When you do receive the command &quot; **stocked**&quot;, print the items with their **names** , **prices** , **quantities** and **total price** of all the products with that name. When you&#39;re done printing the items, print the **grand total price** of all the items.

_Note: The_ **grand total** _is calculated, based on the_ **latest price** _of the products._

### Input

- Until you receive &quot; **stocked**&quot;, the products come in the format: &quot; **{name} {price} {quantity}**&quot;.
- The product data is **always** delimited by a **single space**.

### Output

- Print information about **each**** product**, following the format:
&quot; **{name}: ${price:F2} \* {quantity} = ${total:F2}**&quot;
- On the next line, print **30 dashes**.
- On the final line, print the **grand total** in the following format:
&quot; **Grand Total: ${grandTotal:F2}**&quot;

### Examples

| **Input** | **Output** |
| --- | --- |
| Beer 2.20 100IceTea 1.50 50NukaCola 3.30 80Water 1.00 500stocked | Beer: $2.20 \* 100 = $220.00IceTea: $1.50 \* 50 = $75.00NukaCola: $3.30 \* 80 = $264.00Water: $1.00 \* 500 = $500.00------------------------------Grand Total: $1059.00 |
| Beer 2.40 350Water 1.25 200IceTea 5.20 100Beer 1.20 200IceTea 0.50 120stocked | Beer: $1.20 \* 550 = $660.00
Water: $1.25 \* 200 = $250.00
IceTea: $0.50 \* 220 = $110.00
------------------------------
Grand Total: $1020.00 |
| CesarSalad 10.20 25SuperEnergy 0.80 400EvenSupererEnergy 1.00 400Beer 1.35 350beer 0.50 450IceCream 1.50 25stocked | CesarSalad: $10.20 \* 25 = $255.00SuperEnergy: $0.80 \* 400 = $320.00EvenSupererEnergy: $1.00 \* 400 = $400.00Beer: $1.35 \* 350 = $472.50beer: $0.50 \* 450 = $225.00IceCream: $1.50 \* 25 = $37.50------------------------------Grand Total: $1710.00 |

## Problem 5.Parking Validation

SoftUni just got a huge, shiny new **parking lot** in a super-secret location (under the Code Ground hall). It&#39;s so fancy, it even has online **parking validation**. Except, the online service doesn&#39;t work. It can only receive users&#39; data, but doesn&#39;t know what to do with it. Good thing you&#39;re on the dev team and know how to fix it, right?

Write a program, which validates parking for an online service. Users can **register** to park and **unregister** to leave.

The system supports **license plate validation**. A valid license plate has the following **3** distinct characteristics:

- It is **always**** exactly 8 characters long**.
- Its **first 2** and **last 2 characters** are always **uppercase Latin letters**
- The **4 characters in the middle** are always **digits**

If any of the aforementioned conditions fails, the **license plate** is **invalid**.

The program **receives 2 commands** :

- &quot; **register {username} {licensePlateNumber}**&quot;:
  - The system only supports **one car per user** at the moment, so if a user tries to register **another license plate** , using the **same username** , the system should print:
&quot; **ERROR: already registered with plate number {licensePlateNumber}**&quot;
  - If the **license plate** is **invalid** , the system should print:
&quot; **ERROR: invalid license plate {licensePlateNumber**** }**&quot;
  - If the user tries to register **someone else&#39;s license plate** , the system should print:
&quot; **ERROR: license plate {licensePlateNumber} is busy**&quot;
  - If the aforementioned checks **pass**** successfully **, the plate** can be registered**, so the system should print:
&quot; **{username} registered {licensePlateNumber} successfully**&quot;
- &quot; **unregister {username}**&quot;:
  - If the user is **not present** in the database, the system should print:
&quot; **ERROR: user {username} not found**&quot;
  - If the aforementioned check passes successfully, the system should print:
&quot; **user {username} unregistered successfully**&quot;

After you execute all of the commands, **print** all the currently **registered users** and their **license plates** in the format:

- &quot; **{username} =&gt; {licensePlateNumber}**&quot;

### Input

- First line: **n** – **number of commands** – **integer**
- Next **n** lines: **commands** in one of **two** possible formats:
  - Register: &quot; **register {username} {licensePlateNumber}**&quot;
  - Unregister: &quot; **unregister {username}**&quot;

The input will **always** be **valid** and you **do not need** to check it explicitly.

### Examples

| **Input** | **Output** |
| --- | --- |
| 5register some0ne CS1234JSregister vankata JAVA123Sregister vankata AB4142CDregister housey VR1223EEunregister housey | some0ne registered CS1234JS successfullyERROR: invalid license plate JAVA123Svankata registered AB4142CD successfullyhousey registered VR1223EE successfullyuser housey unregistered successfullysome0ne =&gt; CS1234JSvankata =&gt; AB4142CD |
| 4register testUser AA4132BBregister testuser AA4132BBregister testuser AA9999BBunregister testUser | testUser registered AA4132BB successfullyERROR: license plate AA4132BB is busytestuser registered AA9999BB successfullyuser testUser unregistered successfullytestuser =&gt; AA9999BB |
| 7register gosho mm1111XXregister gosho MM1111xxregister gosho MMaaaaXXunregister goshoregister gosho MM1111XXunregister goshounregister pesho | **ERROR:** invalid license plate mm1111XX **ERROR:** invalid license plate MM1111xx **ERROR:** invalid license plate MMaaaaXXERROR: user gosho not foundgosho registered MM1111XX successfullyuser gosho unregistered successfullyERROR: user pesho not found |
## Problem 6.Byte Flip

Write a program, which receives a **string array** (space-separated), containing **bytes** in **hexadecimal**** format **with the** digits reversed**.

Yourtask is to **remove** any elements whose length is **different than 2** , then **reverse** the digits in **every number** , and finally **reverse** the whole collection and **convert every element** from **hexadecimal**** numbers **to** characters **from the** ASCII table**.

**Print** the resulting string of **ASCII characters** on the console.

### Input

- First line: the **array** of **strings** , representing a **byte array**.

### Output

- First line: The **resulting string** from the input.

### Examples

| **Input** | **Output** |
| --- | --- |
| A 12 B 46 C 56 DDD 46 EEE F6 FFF 36 56 46 | decoded! |
| 37 56 47 97 26 02 D6 56 86 47 02 07 96 C6 66 | flip them bytes |
| E7 E7 E7 155 33 F5 C 23 12 13 | 1!2\_3~~~ |

## Problem 7.\* Take/Skip Rope

Write a program, which reads a **string** and **skips** through it, extracting a **hidden message**. The algorithm you have to implement is as follows:

Let&#39;s take the string &quot; **skipTest\_String044170**&quot; as an example.

Take every **digit** from the string and **store it** somewhere. After that, **remove** all the digits from the string. After this operation, you should have **two lists of items** : the **numbers list** and the **non-numbers list** :

- Numbers list: **[0, 4, 4, 1, 7, 0]**
- Non-numbers: **[s, k, i, p, T, e, s, t, \_, S, t, r, i, n, g]**

After that, take every digit in the **numbers list** and split it up into a **take list** and a **skip list** , depending on whether the digit is in an **even** or an **odd** index:

- Numbers list: **[****0 ****,**  **4**** , **** 4 ****,**  **1**** , **** 7 ****,**  **0****]**
- Take list: **[****0 ****,**  **4**** , **** 7****]**
- Skip list: **[****4 ****,**  **1**** , **** 0****]**

Afterwards, **iterate** over both of the lists and **skip**** {skipCount} **characters from the** non-numbers list **, then** take **** {takeCount} **characters and store it in a** result string **. Note that the skipped characters are** summed up **as they go. The process would look like this on the aforementioned** non-numbers list**:

1. Skip **4** characters (total **0** ), take **0** characters &quot; **skipTest\_String**&quot; Taken: &quot;&quot; Result: &quot;&quot;
2. Skip **1** characters (total **4** ), take **4** characters &quot; **skip**** Test ****\_String**&quot; Taken: &quot; **Test**&quot; Result: &quot; **Test**&quot;
3. Skip **0** characters (total **9** ), take **7** characters &quot; **skipTest\_**** String **&quot; Taken: &quot;** String **&quot; Result: &quot;** TestString**&quot;

After that, just print the **result string** on the console.

### Input

- First line: The **encrypted** message as a **string**

### Output

- First line: The **decrypted** message as a **string**

### Constraints

- The count of digits in the input string will **always be even**.
- The encrypted message will contain any printable ASCII character.

### Examples

| **Input** | **Output** |
| --- | --- |
| T2exs15ti23ng1\_3cT1h3e0\_Roppe | TestingTheRope |
| O{1ne1T2021wf312o13Th111xreve!!@! | OneTwoThree!!! |
| this forbidden mess of an age rating 0127504740 | hidden message |