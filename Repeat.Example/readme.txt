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