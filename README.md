# TriangleExercise

The program analyses three values and determine what type of Triangle they form.

The method AnalyzeTriangle take three input parameters, which all should be Int’s.
Returns a string with either an error or the type of the triangle.

* 1  
Test if triangle is NOT a triangle  
**Input:** AnalyzeTriangle(0,0,0)  
**Expected output**: Error  
* 2  
Test if triangle is Equilateral  
**Input:**: AnalyzeTriangle(30,30,30)  
**Expected output**: Equilateral  
* 3  
Test if triangle is Isosceles  
**Input:**: AnalyzeTriangle(30, 50, 30)  
**Expected output**: Isosceles  
* 4  
 Test if triangle is Scalene  
 Input: AnalyzeTriangle(30,40,50)  
**Expected output**: Scalene  
* 5  
 Test for negative value  
 Input: AnalyzeTriangle(-30,40,50)  
**Expected output**: Error
* 6  
 Test for invalid char  
 Input: AnalyzeTriangle(£,40,50)  
**Expected output**: Error

