 # Exercises: Regular Expressions (RegEx)

This document defines the **exercise assignments** for the [&quot;Programming Fundamentals&quot; course @ Software University](https://softuni.bg/courses/programming-fundamentals). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/430/Regex-Exercise).

## 1.Extract Emails

Write a program to **extract all email addresses from a given text**. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format **&lt;user&gt;@&lt;host&gt;** , where:

- **&lt;user&gt;** is a sequence of **letters** and **digits** , where &#39; **.**&#39;, &#39; **-**&#39; and &#39; **\_**&#39; can appear between them.
  - Examples of valid users: &quot; **stephan**&quot;, &quot; **mike03**&quot;, &quot; **s.johnson**&quot;, &quot; **st\_steward**&quot;, &quot; **softuni-bulgaria**&quot;, &quot; **12345**&quot;.
  - Examples of invalid users: &#39;&#39; **--123**&quot;, &quot; **.....**&quot;, &quot; **nakov\_-**&quot;, &quot; **\_steve**&quot;, &quot; **.info**&quot;.
- **&lt;host&gt;** is a sequence of at least two words, separated by dots &#39; **.**&#39;. Each word is sequence of letters and can have hyphens &#39; **-**&#39; between the letters.
  - Examples of hosts: &quot; **softuni.bg**&quot;, &quot; **software-university.com**&quot;, &quot; **intoprogramming.info**&quot;, &quot; **mail.softuni.org**&quot;.
  - Examples of invalid hosts: &quot; **helloworld**&quot;, &quot; **.unknown.soft.**&quot;, &quot; **invalid-host-**&quot;, &quot; **invalid-**&quot;.
- Examples of **valid emails** : **info@softuni-bulgaria.org** , **kiki@hotmail.co.uk** , **no-reply@github.com** , **s.peterson@mail.uu.net** , **info-bg@software-university.software.academy**.
- Examples of **invalid emails** : **--123@gmail.com** , **…@mail.bg** , **.info@info.info** , **\_steve@yahoo.cn** , **mike@helloworld** , **mike@.unknown.soft****. **,** s.johnson@invalid-**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Please contact us at: support@github.com. | support@github.com |
| Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information. | s.miller@mit.eduj.hopking@york.ac.uk |
| Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de. | steve.parker@softuni.de |

## 2.Extract Sentences by Keyword

Write a program that extracts **all sentences** that **contain** a particular **word** from a string(case-sensitive).

- Assume that the **sentences** are **separated** from each other by the character &quot; **.**&quot; or &quot; **!**&quot; or &quot; **?**&quot;.
- The **words** are separated by a **non-letter character**.
- Note that a **substring** is different than a **word**. The sentence &quot;I am a fan of Mo **to** rhead&quot; does not contain the word &quot; **to**&quot;. It contains the **substring**&quot; **to**&quot;, which is **not** what we need.
- Print the result text **without** the separators between the sentences (&quot; **.**&quot; or &quot; **!**&quot; or &quot; **?**&quot;).

### Examples

| **Input** |
| --- |
| **to** Welcome **to** SoftUni! You will learn programming, algorithms, problem solving and software technologies. You need **to** allocate for study 20-30 hours weekly. Good luck! I am fan of Motorhead. To be or not **to** be - that is the question. TO DO OR NOT? |
| **Output** |
| Welcome **to** SoftUniYou need **to** allocate for study 20-30 hours weeklyTo be or not **to** be - that is the question |

## 3.Camera View

You are an amateur photographer and you want to calculate what will be seen in your pictures.

On the **first** line, you will receive an **array of integers** with exactly **two** elements:

**First** element – **m** will be the elements, which you have to skip. The **second element** – **n** will be the elements, which you have to **take**.

On the **next** line, you will receive a **string** , in which every camera will be marked with &quot; **|&lt;**&quot;. Skip the next **m** elements **immediately** after the camera and **take** the next **n** elements.

If you encounter **new** camera in the **view** ? **stop** the current **camera** and **start**** new ****view** with the newly found.

### Output

Print **all** the taken **views** separated with &quot; **,**&quot;.

### Examples

| **Input** | **Output** |
| --- | --- |
| 9 7GreatBigSea|&lt;uglyStuffHawaii|&lt;boriiiingKilauea | Hawaii, Kilauea |
| 0 5|&gt;invalid|&lt;beach|noMoreCameras | beach |

## 4.Weather

You have to make a weather forecast about the weather depending on **strings** , which you receive from the **console**. Every string consists of **data** about the **city** , **average temperature** and **weather type**. You will receive strings **until** you receive the command &quot; **end**&quot;.

Every **valid** weather forecast **consists** of:

- **Two**** Latin ****capital**** letters **, which represent the code of the** city**
- **Immediately** followed by a **floating-point** number, which will represent the **average temperature**. Numbers **without** afloating point are **not** considered **valid**.
- Followed by the **type** of weather, which will consist of **uppercase** and **lowercase**** Latin ****letters** , starts **immediately**** after **the** temperature **and** ends **at the** first **occurrence of the sign &#39;** |**&#39;

If you receive input, which does **not** follow the rules above – **ignore** it.

If you receive a **new**** temperature **and/or type of weather for a city, which** already exists **–** rewrite** the previous values.

At the end, **print** the **temperature** and **weather type** for **every** city. **Order** the **cities** by **average**** temperature **in** ascending ****order**.

### Input

You will receive strings until you receive the command &quot; **end**&quot;.

### Output

Print **all** cities ordered by **average**** temperature **in** ascending **order. Use the following** format**:

&quot; **{nameOfTheCity} =&gt; {averageTemperature} =&gt; {typeOfWeather}**&quot;

**Format** the temperature to the **2**

# nd
 **decimal place**.
### Constraints

- The average temperature will be in the interval **[0.00…50.00]**
- The **floating-point** numbers will have at most **2** digits after the floating point.

### Examples

| **Input** | **Output** |
| --- | --- |
| PB23.41Rainy|ASDASDSDASCA20.21sUNNY|SDASDasdaCA22.5rainy|sadaCA23.41cloydyend | CA =&gt; 22.50 =&gt; rainyPB =&gt; 23.41 =&gt; Rainy |

| **Input** | **Output** |
| --- | --- |
| invalidKA31.41|sunny|validCA12.41Rainy|absadgfASFasASPA31.21cloudy|asdYA21.51sunny|sadL21.41rainy|adasend | CA =&gt; 12.41 =&gt; RainyYA =&gt; 21.51 =&gt; sunnyPA =&gt; 31.21 =&gt; cloudy |

## 5.Key Replacer

You will be given a **key**** string **and a** text ****string**. The key string will contain a **start**** key **and an** end ****key**.

The **start**** key **starts at the** beginning **of the** string **and** ends **at the** first **occurrence of one of the symbols – &quot;** | **&quot;, &quot;** &lt; **&quot; or &quot;** \ **&quot;. The** end ****key** starts at the **last** occurrence of **one** of **these**** symbols **and** ends **when the** string ****ends**. Both keys can contain **only**** Latin ****alphabet**** letters**.

When you extract **both** keys search for them in the text string and extract every string, which is **between** them. **Concatenate** all **collected**** strings **and** print **the** result **. If the result string is** empty **print &quot;** Empty result**&quot;.

### Input

The input will be read from the **console**. The **first** line will hold the **keys**** string **and the** second **line will hold the** text** to search.

### Output

Print the **concatenated**** message **, if such exists or &quot;** Empty result**&quot;, if it does not.

### Examples

| **Input** | **Output** |
| --- | --- |
| start&lt;213asfaas|endsaaastarthelloendsdarstartFromTheOtherenddvsefdsfstartSideend | helloFromTheOtherSide |

| **Input** | **Output** |
| --- | --- |
| A|safafasfsadf|BNoMEssageABhereYeyAB | Empty result |

## 6.\* Valid Usernames

You are part of the back-end development team of the next Facebook.

You are given a **line of usernames** , **separated** by one of the following symbols: &quot;&quot;, &quot; **/**&quot;, &quot; **\**&quot;, &quot;**(**&quot;, &quot;**)**&quot; **.**

First you have to export all **valid** usernames. A valid username **starts with a letter** and can onlycontain **letters** , **digits** andunderscores &quot; **\_**&quot;. It cannot be **less than 3 or more than 25 symbols** long.

Your task is to **sum** the length of **every**** 2 consecutive ****valid** usernames and print the 2 valid usernames with **biggest**** sum **of their** lengths,** on the console, each on a separate line.

### Input

The input comes from the console. One line will hold all the data. It will hold **usernames,** divided by the symbols:&quot;&quot;, &quot; **/**&quot;, &quot; **\**&quot;, &quot;**(**&quot;, &quot;**)**&quot;.

The input data will **always be valid** and in the format described. There is no need to check it explicitly.

### Output

Print the 2 **consecutive**** valid usernames **with the** biggest ****sum** of their lengths on the console, each on a separate line.

If there are **2 or more couples** of usernames with the same sum of their lengths, print the **left most**.

### Constraints

- The input line will hold characters in the range [0 … 9999].
- The usernames should **start with a letter** and can contain **only letters, digits and**&quot; **\_**&quot;.
- The username cannot be **less than 3 or**** more than 25 symbols** long.
- Time limit: 0.5 sec. Memory limit: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| ds3bhj y1ter/wfsdg 1nh\_jgf ds2c\_vbg\4htref | wfsdgds2c\_vbg |

| **Input** | **Output** |
| --- | --- |
| min23/ace hahah21 (    sasa  )  att3454/a/a2/abc | hahah21sasa |

| **Input** | **Output** |
| --- | --- |
| chico/ gosho \ sapunerka (3sas) mazut  lelQ\_Van4e | mazutlelQ\_Van4e |
## 7.\* Query Mess

**Ivancho** participates in a team **project** with colleagues at **SoftUni**.  They have to develop **an application** , but something _mysterious_ happened – at the last moment all team members… disappeared!  And guess what? He is left **alone** to finish the project.  All that is left to do is to parse the input data and store it in a special way, but Ivancho has no idea how to do that! Can you help him?

### Input

The input comes from the console on a variable number of lines and ends when the keyword &quot;END&quot; is received.

For each row of the input, the query string contains **field=value** pairs. Within each pair, the field name and value are separated by an equals sign, &#39; **=**&#39;. The series of pairs are separated by an ampersand, &#39; **&amp;**&#39;. The **question mark** is used as a separator and is **not** part of the query string. A URL query string may contain another URL as value. The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

**For each input line, print** on the console a line containing the **processed string as follows** :  **key=[value]nextkey=[another value] ... etc.**

**Multiple whitespace** characters should be reduced to one inside value/key names, but there shouldn&#39;t be any whitespaces before/after extracted **keys** and **values**. If a key **already exists** , the value is added with comma and space after other values of the existing key in the current string.  See the **examples** below.

### Constraints

- **SPACE** is encoded as &#39; **+**&#39; or &quot; **%20**&quot;.Letters (A-Z and a-z), numbers (0-9), the characters &#39; **\***&#39;, &#39; **-**&#39;, &#39; **.**&#39;, &#39; **\_**&#39; and _other non-special symbols_ are left as-is.
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** |
| --- |
| login=student&amp;password=studentEND |
| **Output** |
| login=[student]password=[student] |

| **Input** |
| --- |
| field=value1&amp;field=value2&amp;field=value3http://example.com/over/there?name=ferretEND |
| **Output** |
| field=[value1, value2, value3]name=[ferret] |

| **Input** |
| --- |
| foo=%20foo&amp;value=+val&amp;foo+=5+%20+203foo=poo%20&amp;value=valley&amp;dog=wow+url=https://softuni.bg/trainings/coursesinstances/details/1070https://softuni.bg/trainings.asp?trainer=nakov&amp;course=oop&amp;course=phpEND |
| **Output** |
| foo=[foo, 5 203]value=[val]foo=[poo]value=[valley]dog=[wow]url=[https://softuni.bg/trainings/coursesinstances/details/1070]trainer=[nakov]course=[oop, php] |

## 8.\*Use Your Chains, Buddy

**This problem is from the JavaScript Basics Exam (9 January 2015). You may check your solution** [**here**](https://judge.softuni.bg/Contests/Practice/Index/56#2) **.**

You are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut. You need to get there by car. But there is so much snow that you need to use car chains. In order to put them on the wheels correctly, you need to read the manual. But it is encrypted…

As input you will receive **an HTML document** as a **single string**. You need to get the text from **all the &lt;p&gt; tags** and replace all characters which are **not small letters and numbers** with a space **&quot; &quot;**. After that you must decrypt the text – all letters **from a to m** are **converted** to letters **from n to z** (a ? n; b ? o; … m ? z). The letters **from n to z** are **converted** to letters **from a to m** (n ? a; o ? b; … z ? m). All **multiple** spaces should then be replaced by only **one space**.

For example, if we have **&quot;&lt;div&gt;Santa&lt;/div&gt;&lt;p&gt;znahny # grkg ()&amp;^^^&amp;12&lt;/p&gt;&quot;** we extract **&quot;znahny # grkg ()&amp;^^^&amp;12&quot;**. Every **character** that is **not a small letter or a number** is replaced with aspace ( **&quot;znahny grkg       12&quot;** ). We convert each small letter as described above ( **&quot;znahny grkg       12&quot;**  **?**  **&quot;manual text       12&quot;** ) and replace all multiple spaces with only **one space** ( **&quot;manual text 12&quot;** ). Finally, we concatenate the decrypted text from all **&lt;p&gt;&lt;/p&gt;** tags (in this case, it&#39;s only one). And there you go – you have the manual ready to read!

### Input

The input is read from the console and consists of just one line – the **string** with the **HTML document**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

**Print** on a single line the decrypted text of the manual. See the given **examples** below.

### Constraints

- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

### Examples

| **Input** |
| --- |
| &lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;hello&lt;/h1&gt;&lt;p&gt; **znahny!@#%&amp;&amp;&amp;&amp;\*\*\*\*** &lt;/p&gt;&lt;div&gt;&lt;button&gt;dsad&lt;/button&gt;&lt;/div&gt;&lt;p&gt;**grkg^^^^%%%)))([]12**&lt;/p&gt;&lt;/body&gt;&lt;/html&gt; |
| **Output** |
| manual text 12 |

| **Input** |
| --- |
| &lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;Intro&lt;/h1&gt;&lt;ul&gt;&lt;li&gt;Item01&lt;/li&gt;&lt;li&gt;Item02&lt;/li&gt;&lt;li&gt;Item03&lt;/li&gt;&lt;/ul&gt;&lt;p&gt; **jura qevivat va jrg fyvccrel fabjl** &lt;/p&gt;&lt;div&gt;&lt;button&gt;Click me, baby!&lt;/button&gt;&lt;/div&gt;&lt;p&gt; **pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx** &lt;/p&gt;&lt;span&gt;This manual is false, do not trust it! The illuminati wrote it down to trick you!&lt;/span&gt;&lt;p&gt; **vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg** &lt;/p&gt;&lt;p&gt; **pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf** &lt;/p&gt;&lt;/body&gt; |
| **Output** |
| when driving in wet slippery snowy conditions snow chains are absolutely essential for safe handling although snow chains may look intimidating the basic idea is really simple fit them over your tires drive forward slowly and tighten them up in cold wet conditions this is easier said than done but if you put on your tires |