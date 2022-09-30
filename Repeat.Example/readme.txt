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