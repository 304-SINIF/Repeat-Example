1.0
Tanımlama formülleri
	<var_type> <var_name>;
	<var_type> <var_name> = <value>;
- C#'a göre değişkenler tiplerinin izin verdiği değerleri taşıyabilir
- Bir değeri saklamak istiyorsanız değişken tanımlarsınız
- İlkel değişken tipleri; bool, byte, short, int, long, char, string, float, double, decimal

2.0
	2.1 Aritmetik Operatörler
		- +, -, *, /, %
		Matematiksel işlemler için kullanılırlar

	2.2 Atama Operatörleri
		=, +=, -=, *=, /=, %=, ++, --
		Formül: <var> <OPERATOR> <value>
		Sağdan sola okunurlar. Sağdaki değer soldaki değişkene atanır.

	2.3 Mantıksal Operatörler
		== : Değer eşitliği kontrolü yapar
		!= : Değer eşitsizliği kontrolü yapar
		!  : Değil
		&& : (AND) İki önermenin de doğru olduğu durumlarda "true" döndürür
		|| : (OR) İki önermeden birinin ya da her ikisinin de doğru olduğu durumlarda "true" döndürür
		^  : (XOR) Önermelerin birbirinden farklı olduğu durumlarda "true" döndürür
		<, <=, >, >=

3.0
	Program içerisinde mantıksal bir karar vermek için kullanılırlar
	3.1
		if
		- Yukarıdan aşağıya, gerçekleşen koşulu bulana dek, if'in parantezleri arasındaki kodu çalıştırarak bir boolean sonuç bekler
		- Sadece if, if-else if(∞), if-else, if-else if(∞)-else, şeklinde karar ağacı kurabilirsiniz
	3.2
		switch
		- Yalnızca eşitlik kontrolü yapılabilir
		- case ifadeleri alt alta yazıldığında OR anlamına gelir
		
4.0
	Bir tipin bir başka tipe dönüştürülmesi için kullanılır. Örneğin konsoldan yapılan giriş tipi string olarak geleceğinden toplama işlemi yaptığımızda bu ifade concate edilir (stringlerde toplama), fakat amaç iki sayının aritmetik toplamıysa, konsoldan gelen değerin numerik bir değere dönüştürülmesi gerekir

		4.1
		Convert classı içerisinde tipler birbirine dönüşebilecekleri methodlar vardır. Örneğin int'ten double'a çevrilebilir

		4.2
		Tiplerin altında barınan Parse methodu yalnızca stringden çeviri yapabilir

		4.3
		TryParse methodu, çevrilmek istenilen değerin çevrilip çevrilemeyeceğine bakar. Eğer çevrilebiliyorsa geriye "true" döndürür, değişen değeri "out" parametresinin değişkenine atar aksi takdirde "false" döndürür ve "out" değişkenin tipinin varsayılan değerini atar. Böylelikle "Exception Handling" yapmak yerine "Validation" yapılabilir

		4.4
		Her tip içerisinde ToString methodunu barındırır.
			4.4.1
				Bu method ilkel değişkenlerde, değerlerinin string versiyonunu döndürürken,
			
			4.4.2
				geriye kalan tipler yalnızca tipinin ne olduğunu string bir ifade olarak döndürür
			4.4.3
				(eğer ne yapacağını belirtmiş olan bir tip değilse)

5.0
	"Exception Handling" anlamına gelir, hata fırlatmaya müsait kod blokları için kullanılır. Eğer bu hata rahatlıkla öngörülebiliyor ve Validation yapılabiliyorsa, hatanın bu şekilde çözümü daha uygundur. Ancak hata fırlatmaya müsait bir bloğun öngörülemeyen bir hata fırlatma olasılığı varsa ya da fırlatılan hataların loglama işlemine tabi tutulması gerekiyorsa kullanılması uygundur

	Not: try ve catch kullanmak zorunludur

	5.1
	catch bloğu parantezleri arasına hata tipi alabilir. Bunun sebebi try-catch bloğu birden fazla catch bloğu barındırabilir. Bu catch bloklarını ayıran, yakaladıkları tiptir. Bunu sağlamak için catch bloğunun parantezleri arasına yakalanacak tip yazılır. Örnekte görüldüğü gibi bu kod bloğu birden fazla hata ile sonuçlanabilir. Eğer format hatası varsa, uygun bir hata mesajı döndürmek için FormatException bloğu kullanılır. DivideByZeroException ise 0'a bölünme durumunda kullanılacaktır.

	Not: Eğer blokta yukarıda yer alan Exception tipi, aşağıda yer alanı kapsıyor ise, program derlenmeyecektir. Örneğin, Exception tipi en aşağıda olmak zorundadır. ArithmeticException, DivideByZeroException bloğunun yukarısında olamaz

	5.2
	catch bloğunda yalnızca exception tipi değil aynı zamanda exception objeside talep edilebilir. Bu obje içerisinde, hatanın kaynağı, hataya sebep olan (varsa) hatayı, hata mesajı gibi değerler tutar

	5.3
	"Exception Handling" yapılırken try ve catch yazılmak zorunluyken, dilenirse "finally" bloğu koyulabilir. Bu blok hata olsun olmasın çalışacaktır

6.0
	Bir döngü 3 öğe barındırır
		1. Başlangıç değeri (<loop_condition_var>)
		2. Koşul (<condition>)
		3. Artış (<loop_condition_var_increment>)
	Geriye kalan, döngünün kapsamında kalan kod bloğu, döngü devam ettikçe çalıştırılacaktır

	6.1
	int <loop_condition_var> = <value>;
	while (<condition>)
	{

		<loop_condition_var_increment>
	}

	6.2
	int <loop_condition_var> = <value>;
	do
	{

		<loop_condition_var_increment>
	}
	while (<condition>);

	do-while ve while arasındaki fark, do bloğu koşul kontrol edilmeden önce en az bir kez çalıştırılır

	6.3
	for (<loop_condition_var>; <condition>; <loop_condition_var_increment>)
	{
	
	}

7.0
	Birden fazla değer tutmak için kullanılır
	<var_type>[] <var_name> = new <var_type>[<arr_length>];
	<var_type>[] <var_name> = { <value1>, <value2>... };

	7.1
		Array barındıran array

	7.2
		İki boyutlu array
	<var_type>[,] <var_name> = new <var_type>[<row_length>, <col_length>];
