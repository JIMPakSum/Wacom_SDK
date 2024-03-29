// Copyright MyScript. All rights reserved.

namespace MyScript.Certificate
{

  /// <summary>
  /// The <c>MyCertificate</c> class provides the bytes of the user
  /// certificate used to grant the access to the MyScript technologies.
  /// </summary>
  public sealed class MyCertificate
  {
    /// <summary>
    /// Read only property that returns the bytes of the user certificate.
    /// </summary>
    ///
    /// <value>
    /// The bytes of the user certificate.
    /// </value>
    public static sbyte[] Bytes
    {
      get
      {
          return BYTES;
      }
    }

    /// <summary>
    /// The bytes of the user certificate.
    /// </summary>
    private static readonly sbyte[] BYTES = new sbyte[]
    {
      109,  -98,  118,  -103, 50,   -54,  21,   -116, 
      107,  -72,  26,   -110, 44,   58,   -14,  69,   
      -99,  50,   -9,   -66,  -46,  -108, -59,  122,  
      36,   66,   11,   14,   -74,  -86,  101,  127,  
      -15,  -40,  -97,  60,   41,   -71,  12,   23,   
      -62,  -47,  -106, 118,  72,   -113, -56,  123,  
      -49,  -79,  -21,  108,  58,   -56,  -35,  -25,  
      -92,  11,   -126, -50,  73,   5,    -17,  -78,  
      89,   28,   90,   72,   52,   -83,  46,   -97,  
      8,    -32,  -32,  56,   -23,  -106, 70,   18,   
      50,   105,  -103, 49,   3,    81,   98,   -120, 
      -125, 64,   -93,  -58,  115,  86,   -34,  0,    
      18,   4,    48,   -88,  -106, -60,  27,   109,  
      76,   -85,  -79,  -6,   46,   -97,  57,   50,   
      -69,  -110, -87,  71,   -9,   47,   1,    -50,  
      -87,  13,   -68,  -117, -57,  28,   -48,  -81,  
      91,   25,   -63,  -19,  53,   -75,  102,  73,   
      1,    51,   110,  -84,  -125, 63,   -98,  83,   
      -21,  -63,  -36,  41,   -28,  -32,  -13,  18,   
      -125, -94,  66,   70,   70,   -20,  -17,  -47,  
      70,   10,   72,   59,   -78,  -94,  -45,  -71,  
      87,   53,   63,   109,  -5,   81,   9,    16,   
      -2,   65,   115,  -47,  58,   -84,  66,   -32,  
      -59,  26,   17,   107,  103,  -31,  -35,  104,  
      -120, -63,  65,   45,   -11,  -69,  61,   34,   
      20,   -65,  -123, -31,  100,  34,   67,   75,   
      81,   -111, -32,  -70,  -37,  120,  44,   116,  
      72,   -62,  -20,  -18,  112,  -84,  121,  -113, 
      -6,   17,   -114, -51,  72,   -103, 100,  10,   
      11,   92,   1,    63,   -61,  96,   -126, 118,  
      -54,  -43,  -102, -30,  -11,  -79,  -118, 41,   
      68,   -11,  -120, -38,  21,   -90,  -78,  103,  
      34,   -89,  109,  30,   -82,  72,   28,   65,   
      124,  83,   -42,  86,   -102, -76,  55,   -126, 
      69,   -91,  111,  30,   68,   18,   -117, 66,   
      -80,  40,   69,   85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -101, -76,  55,   -126, 
      39,   70,   -78,  28,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  68,   18,   -117, 66,   
      -64,  21,   101,  87,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -101, -76,  55,   -126, 
      -9,   -39,  90,   27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  68,   18,   -117, 66,   
      -6,   -70,  -103, 84,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -101, -76,  55,   -126, 
      -107, -28,  -47,  27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  68,   18,   -117, 66,   
      96,   -120, 70,   82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -101, -76,  55,   -126, 
      18,   41,   -26,  31,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  71,   18,   -117, 66,   
      125,  32,   18,   83,   -98,  -92,  55,   -126, 
      33,   -91,  111,  30,   -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -104, -76,  55,   -126, 
      70,   -97,  107,  28,   67,   2,    -117, 66,   
      120,  -34,  -15,  86,   101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  71,   18,   -117, 66,   
      -100, -34,  5,    85,   -112, -92,  55,   -126, 
      38,   -91,  111,  30,   -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -104, -76,  55,   -126, 
      41,   61,   -116, 28,   74,   2,    -117, 66,   
      120,  -34,  -15,  86,   101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  71,   18,   -117, 66,   
      39,   -119, -112, 87,   -119, -92,  55,   -126, 
      42,   -91,  111,  30,   -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -104, -76,  55,   -126, 
      -13,  -109, -39,  29,   89,   2,    -117, 66,   
      118,  -34,  -15,  86,   101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  71,   18,   -117, 66,   
      4,    108,  39,   82,   -68,  -92,  55,   -126, 
      43,   -91,  111,  30,   -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -104, -76,  55,   -126, 
      -67,  -43,  104,  31,   107,  2,    -117, 66,   
      123,  -34,  -15,  86,   101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  71,   18,   -117, 66,   
      101,  -99,  -65,  87,   -119, -92,  55,   -126, 
      32,   -91,  111,  30,   -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -104, -76,  55,   -126, 
      -101, -47,  19,   27,   112,  2,    -117, 66,   
      116,  -34,  -15,  86,   101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  65,   18,   -117, 66,   
      33,   -119, 4,    82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -98,  -76,  55,   -126, 
      -55,  8,    -96,  29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  65,   18,   -117, 66,   
      -87,  -15,  -80,  85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -98,  -76,  55,   -126, 
      111,  78,   114,  29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      102,  -99,  41,   82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      74,   0,    28,   31,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      113,  -38,  5,    85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      92,   -128, -55,  28,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      94,   -68,  -110, 82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -88,  38,   -41,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      87,   -57,  23,   86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      117,  118,  -104, 30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      58,   -44,  -40,  87,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -111, 51,   66,   31,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      20,   -44,  120,  87,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      3,    66,   -99,  31,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -2,   -49,  9,    87,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      107,  20,   95,   28,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -12,  119,  -61,  84,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      124,  126,  51,   28,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -115, -76,  -82,  84,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      26,   59,   -61,  28,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      78,   8,    45,   84,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      7,    -72,  110,  29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      48,   -47,  -111, 85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -31,  21,   10,   29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -43,  54,   -105, 85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -117, -1,   2,    29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -113, -110, 116,  85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      36,   10,   -59,  29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      105,  52,   92,   85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      51,   72,   -42,  29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -114, -74,  48,   85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      31,   110,  -119, 29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      51,   88,   25,   85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -101, 75,   -112, 29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -121, -28,  -14,  82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -81,  72,   102,  26,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      6,    -89,  -90,  82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      29,   -88,  54,   26,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -52,  76,   -114, 82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -116, 16,   -5,   26,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -27,  -99,  102,  82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -58,  34,   -10,  26,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -3,   29,   89,   82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      75,   9,    -35,  26,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      53,   125,  57,   82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -6,   -19,  -75,  26,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      79,   35,   46,   82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      73,   -66,  -125, 26,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      99,   -32,  5,    82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      104,  -94,  109,  27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      13,   -39,  -6,   83,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -108, 102,  98,   27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      71,   91,   -60,  83,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      82,   66,   55,   27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -38,  56,   -85,  83,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -72,  56,   7,    27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -75,  -118, -100, 83,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      118,  4,    28,   27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -25,  -86,  -123, 83,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -48,  -70,  -30,  27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -87,  -104, 98,   83,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -96,  114,  -47,  27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      12,   121,  36,   83,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      82,   -13,  -105, 28,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      97,   97,   -49,  85,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -94,  52,   -34,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      15,   77,   -61,  83,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -97,  -18,  51,   29,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -51,  4,    -103, 84,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -46,  69,   -53,  28,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      127,  22,   -5,   82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -58,  -20,  28,   31,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -67,  35,   42,   87,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      116,  -72,  -73,  28,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      78,   81,   -101, 87,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      108,  74,   -127, 26,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -105, -105, 60,   82,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -74,  -111, 18,   31,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  70,   18,   -117, 66,   
      -6,   16,   -99,  87,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      103,  -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -103, -76,  55,   -126, 
      -72,  105,  62,   27,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      56,   -91,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  64,   18,   -117, 66,   
      124,  -34,  -15,  86,   -89,  -92,  55,   -126, 
      17,   -92,  111,  30,   -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  -100, -76,  55,   -126, 
      -36,  90,   -112, -31,  42,   3,    -117, 66,   
      76,   -34,  -15,  86,   101,  75,   -56,  125,  
      -36,  90,   -112, -31,  -70,  -19,  116,  -67,  
      -125, 33,   14,   -87,  101,  75,   -56,  125,  
      -36,  90,   -112, -31,  119,  86,   -58,  35,   
      8,    -74,  -94,  62,   -5,   -60,  82,   -42,  
      70,   -35,  27,   87,   43,   121,  -40,  39,   
      29,   -84,  -110, 62,   -54,  -58,  82,   -26,  
      74,   -58,  27,   119,  42,   124,  -49,  45,   
      31,   -85,  -100, 51,   -12,  -64,  112,  -25,  
      80,   -47,  26,   108,  32,   83,   -27,  35,   
      16,   -89,  -117, 51,   -24,  -41,  -16,  -25,  
      115,  -62,  91,   86,   69,   53,   -104, 96,   
      12,   -18,  115,  87,   -72,  -124, 58,   -124, 
      42,   -113, -23,  86,   -61,  -27,  -122, 67,   
      125,  -33,  -12,  86,   -103, 54,   54,   -115, 
      35,   -107, -19,  31,   79,   16,   9,    67,   
      125,  -34,  9,    40,   87,   55,   -28,  -48,  
      52,   -43,  -103, -104, 81,   28,   -10,  -106, 
      -98,  -18,  -45,  18,   -117, -62,  118,  54,   
      -46,  -9,   -106, 115,  98,   41,   115,  102,  
      -124, 107,  6,    -31,  109,  121,  -44,  82,   
      -78,  -22,  -117, -86,  109,  -2,   89,   19,   
      -42,  111,  80,   66,   53,   81,   -93,  111,  
      38,   -42,  104,  -110, -26,  -44,  -122, 17,   
      112,  -104, -30,  -76,  71,   49,   -104, -96,  
      71,   -17,  -14,  -113, -121, 118,  40,   -29,  
      126,  -117, -102, 116,  27,   -57,  -23,  -124, 
      -106, 18,   -11,  67,   104,  -71,  93,   97,   
      -124, -84,  109,  21,   -112, 18,   67,   -99,  
      73,   -91,  -109, -117, 36,   -14,  -71,  -15,  
      -47,  118,  36,   -5,   -67,  92,   70,   63,   
      -45,  -15,  -57,  -65,  -103, -33,  -29,  80,   
      -71,  -119, -17,  1,    87,   22,   6,    -73,  
      70,   -63,  -18,  28,   -38,  66,   72,   39,   
      -76,  18,   70,   121,  -12,  -99,  76,   -94,  
      -113, 59,   45,   -86,  123,  -77,  -33,  -32,  
      -45,  48,   -126, 68,   -69,  80,   77,   -97,  
      66,   59,   106,  115,  -58,  -73,  96,   1,    
      -16,  84,   -117, -5,   -1,   -72,  7,    115,  
      -5,   -128, -109, 37,   -62,  -40,  85,   -80,  
      -32,  -117, -4,   -16,  22,   -36,  -126, 55,   
      -107, -99,  -40,  54,   59,   113,  -102, 122,  
      -93,  86,   -29,  -16,  -29,  -65,  120,  55,   
      -106, 66,   -7,   -20,  34,   -69,  -56,  84,   
      -5,   64,   64,   54,   36,   36,   89,   24,   
      123,  -72,  108,  -70,  -111, 33,   41,   30,   
      117,  -6,   -16,  -55,  71,   10,   -93,  -90,  
      112,  59,   107,  -72,  75,   16,   104,  52,   
      -25,  -43,  -13,  85,   -101, -76,  54,   -22,  
      87,   -47,  31,   109,  127,  61,   -92,  35,   
      8,    -75,  -33,  59,   -29,  -57,  84,   -16,  
      74,   -43,  27,   48,   38,   125,  -26,  109,  
      24,   -69,  -121, 63,   -7,   -47,  8,    -29,  
      83,   -43,  38,   90,   120,  55,   -8,   100,  
      24,   -65,  -123, 55,   -89,  -111, 68    
    };
  };
}
