namespace YyNameSpace
{
using System;
using System.Text;
class Sample
{
public static void Main(String[] argv)
  {
  String [] args = Environment.GetCommandLineArgs();
  System.IO.FileStream f = new System.IO.FileStream(args[1], System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read, 8192);
  Yylex yy = new Yylex(f);
  Yytoken t;
  while ((t = yy.yylex()) != null)
    Console.WriteLine(t);
  }
}
class Utility {
  public static void assert
   (
   bool expr
   )
    { 
    if (false == expr)
      throw new ApplicationException("Error: Assertion failed.");
    }
  private static String[] errorMsg = new String[]
    {
    "Error: Unmatched end-of-comment punctuation.",
    "Error: Unmatched start-of-comment punctuation.",
    "Error: Unclosed string.",
    "Error: Illegal character."
    };
  public const int E_ENDCOMMENT = 0; 
  public const int E_STARTCOMMENT = 1; 
  public const int E_UNCLOSEDSTR = 2; 
  public const int E_UNMATCHED = 3; 
  public static void error
    (
    int code
    )
    {
    Console.WriteLine(errorMsg[code]);
    }
  }
class Yytoken  {
  internal Yytoken
    (
    int index,
    String text,
    int line,
    int charBegin,
    int charEnd
    )
    {
    m_index = index;
    m_text = text;
    m_line = line;
    m_charBegin = charBegin;
    m_charEnd = charEnd;
    }
  public int m_index;
  public String m_text;
  public int m_line;
  public int m_charBegin;
  public int m_charEnd;
  public override String ToString() {
    return "Token #"+ m_index.ToString()+ ": " + m_text  + " (line "+ m_line.ToString() + ")";
    }
  }
/* test */


internal class Yylex
{
private const int YY_BUFFER_SIZE = 512;
private const int YY_F = -1;
private const int YY_NO_STATE = -1;
private const int YY_NOT_ACCEPT = 0;
private const int YY_START = 1;
private const int YY_END = 2;
private const int YY_NO_ANCHOR = 4;
delegate Yytoken AcceptMethod();
AcceptMethod[] accept_dispatch;
private const int YY_BOL = 128;
private const int YY_EOF = 129;

private static int comment_count = 0;
private System.IO.TextReader yy_reader;
private int yy_buffer_index;
private int yy_buffer_read;
private int yy_buffer_start;
private int yy_buffer_end;
private char[] yy_buffer;
private int yychar;
private int yyline;
private bool yy_at_bol;
private int yy_lexical_state;

internal Yylex(System.IO.TextReader reader) : this()
  {
  if (null == reader)
    {
    throw new System.ApplicationException("Error: Bad input stream initializer.");
    }
  yy_reader = reader;
  }

internal Yylex(System.IO.FileStream instream) : this()
  {
  if (null == instream)
    {
    throw new System.ApplicationException("Error: Bad input stream initializer.");
    }
  yy_reader = new System.IO.StreamReader(instream);
  }

private Yylex()
  {
  yy_buffer = new char[YY_BUFFER_SIZE];
  yy_buffer_read = 0;
  yy_buffer_index = 0;
  yy_buffer_start = 0;
  yy_buffer_end = 0;
  yychar = 0;
  yyline = 0;
  yy_at_bol = true;
  yy_lexical_state = YYINITIAL;
accept_dispatch = new AcceptMethod[] 
 {
  null,
  null,
  new AcceptMethod(this.Accept_2),
  new AcceptMethod(this.Accept_3),
  new AcceptMethod(this.Accept_4),
  new AcceptMethod(this.Accept_5),
  new AcceptMethod(this.Accept_6),
  new AcceptMethod(this.Accept_7),
  new AcceptMethod(this.Accept_8),
  new AcceptMethod(this.Accept_9),
  new AcceptMethod(this.Accept_10),
  new AcceptMethod(this.Accept_11),
  new AcceptMethod(this.Accept_12),
  new AcceptMethod(this.Accept_13),
  new AcceptMethod(this.Accept_14),
  new AcceptMethod(this.Accept_15),
  new AcceptMethod(this.Accept_16),
  new AcceptMethod(this.Accept_17),
  new AcceptMethod(this.Accept_18),
  new AcceptMethod(this.Accept_19),
  new AcceptMethod(this.Accept_20),
  new AcceptMethod(this.Accept_21),
  new AcceptMethod(this.Accept_22),
  new AcceptMethod(this.Accept_23),
  new AcceptMethod(this.Accept_24),
  new AcceptMethod(this.Accept_25),
  new AcceptMethod(this.Accept_26),
  new AcceptMethod(this.Accept_27),
  new AcceptMethod(this.Accept_28),
  new AcceptMethod(this.Accept_29),
  new AcceptMethod(this.Accept_30),
  new AcceptMethod(this.Accept_31),
  new AcceptMethod(this.Accept_32),
  new AcceptMethod(this.Accept_33),
  new AcceptMethod(this.Accept_34),
  new AcceptMethod(this.Accept_35),
  null,
  new AcceptMethod(this.Accept_37),
  new AcceptMethod(this.Accept_38),
  new AcceptMethod(this.Accept_39),
  new AcceptMethod(this.Accept_40),
  new AcceptMethod(this.Accept_41),
  null,
  new AcceptMethod(this.Accept_43),
  new AcceptMethod(this.Accept_44),
  new AcceptMethod(this.Accept_45),
  null,
  new AcceptMethod(this.Accept_47),
  };
  }

Yytoken Accept_2()
    { // begin accept action #2
{ return (new Yytoken(0,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #2

Yytoken Accept_3()
    { // begin accept action #3
{ return (new Yytoken(1,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #3

Yytoken Accept_4()
    { // begin accept action #4
{ return (new Yytoken(2,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #4

Yytoken Accept_5()
    { // begin accept action #5
{ return (new Yytoken(3,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #5

Yytoken Accept_6()
    { // begin accept action #6
{ return (new Yytoken(4,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #6

Yytoken Accept_7()
    { // begin accept action #7
{ return (new Yytoken(5,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #7

Yytoken Accept_8()
    { // begin accept action #8
{ return (new Yytoken(6,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #8

Yytoken Accept_9()
    { // begin accept action #9
{ return (new Yytoken(7,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #9

Yytoken Accept_10()
    { // begin accept action #10
{ return (new Yytoken(8,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #10

Yytoken Accept_11()
    { // begin accept action #11
{ return (new Yytoken(9,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #11

Yytoken Accept_12()
    { // begin accept action #12
{ return (new Yytoken(10,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #12

Yytoken Accept_13()
    { // begin accept action #13
{ return (new Yytoken(11,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #13

Yytoken Accept_14()
    { // begin accept action #14
{ return (new Yytoken(12,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #14

Yytoken Accept_15()
    { // begin accept action #15
{ return (new Yytoken(13,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #15

Yytoken Accept_16()
    { // begin accept action #16
{ return (new Yytoken(14,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #16

Yytoken Accept_17()
    { // begin accept action #17
{ return (new Yytoken(16,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #17

Yytoken Accept_18()
    { // begin accept action #18
{ return (new Yytoken(18,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #18

Yytoken Accept_19()
    { // begin accept action #19
{ return (new Yytoken(20,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #19

Yytoken Accept_20()
    { // begin accept action #20
{ return (new Yytoken(21,yytext(),yyline,yychar,yychar+1)); }
    } // end accept action #20

Yytoken Accept_21()
    { // begin accept action #21
{ return null; }
    } // end accept action #21

Yytoken Accept_22()
    { // begin accept action #22
{ return null; }
    } // end accept action #22

Yytoken Accept_23()
    { // begin accept action #23
{
	StringBuilder sb = new StringBuilder("Illegal character: <");
	String s = yytext();
	for (int i = 0; i < s.Length; i++)
	  if (s[i] >= 32)
	    sb.Append(s[i]);
	  else
	    {
	    sb.Append("^");
	    sb.Append(Convert.ToChar(s[i]+'A'-1));
	    }
        sb.Append(">");
	Console.WriteLine(sb.ToString());	
	Utility.error(Utility.E_UNMATCHED);
        return null;
}
    } // end accept action #23

Yytoken Accept_24()
    { // begin accept action #24
{
	String str =  yytext().Substring(1,yytext().Length);
	Utility.error(Utility.E_UNCLOSEDSTR);
	Utility.assert(str.Length == yytext().Length - 1);
	return (new Yytoken(41,str,yyline,yychar,yychar + str.Length));
}
    } // end accept action #24

Yytoken Accept_25()
    { // begin accept action #25
{ 
	return (new Yytoken(42,yytext(),yyline,yychar,yychar + yytext().Length));
}
    } // end accept action #25

Yytoken Accept_26()
    { // begin accept action #26
{
	return (new Yytoken(43,yytext(),yyline,yychar,yychar + yytext().Length));
}
    } // end accept action #26

Yytoken Accept_27()
    { // begin accept action #27
{ return (new Yytoken(22,yytext(),yyline,yychar,yychar+2)); }
    } // end accept action #27

Yytoken Accept_28()
    { // begin accept action #28
{ yybegin(COMMENT); comment_count = comment_count + 1; return null;
}
    } // end accept action #28

Yytoken Accept_29()
    { // begin accept action #29
{ return (new Yytoken(17,yytext(),yyline,yychar,yychar+2)); }
    } // end accept action #29

Yytoken Accept_30()
    { // begin accept action #30
{ return (new Yytoken(15,yytext(),yyline,yychar,yychar+2)); }
    } // end accept action #30

Yytoken Accept_31()
    { // begin accept action #31
{ return (new Yytoken(19,yytext(),yyline,yychar,yychar+2)); }
    } // end accept action #31

Yytoken Accept_32()
    { // begin accept action #32
{
	String str =  yytext().Substring(1,yytext().Length - 1);
	Utility.assert(str.Length == yytext().Length - 2);
	return (new Yytoken(40,str,yyline,yychar,yychar + str.Length));
}
    } // end accept action #32

Yytoken Accept_33()
    { // begin accept action #33
{ return null; }
    } // end accept action #33

Yytoken Accept_34()
    { // begin accept action #34
{ 
	comment_count = comment_count - 1; 
	Utility.assert(comment_count >= 0);
	if (comment_count == 0) {
    		yybegin(YYINITIAL);
		}
        return null;
}
    } // end accept action #34

Yytoken Accept_35()
    { // begin accept action #35
{ comment_count = comment_count + 1; return null;
}
    } // end accept action #35

Yytoken Accept_37()
    { // begin accept action #37
{ return null; }
    } // end accept action #37

Yytoken Accept_38()
    { // begin accept action #38
{
	StringBuilder sb = new StringBuilder("Illegal character: <");
	String s = yytext();
	for (int i = 0; i < s.Length; i++)
	  if (s[i] >= 32)
	    sb.Append(s[i]);
	  else
	    {
	    sb.Append("^");
	    sb.Append(Convert.ToChar(s[i]+'A'-1));
	    }
        sb.Append(">");
	Console.WriteLine(sb.ToString());	
	Utility.error(Utility.E_UNMATCHED);
        return null;
}
    } // end accept action #38

Yytoken Accept_39()
    { // begin accept action #39
{
	String str =  yytext().Substring(1,yytext().Length);
	Utility.error(Utility.E_UNCLOSEDSTR);
	Utility.assert(str.Length == yytext().Length - 1);
	return (new Yytoken(41,str,yyline,yychar,yychar + str.Length));
}
    } // end accept action #39

Yytoken Accept_40()
    { // begin accept action #40
{
	String str =  yytext().Substring(1,yytext().Length - 1);
	Utility.assert(str.Length == yytext().Length - 2);
	return (new Yytoken(40,str,yyline,yychar,yychar + str.Length));
}
    } // end accept action #40

Yytoken Accept_41()
    { // begin accept action #41
{ return null; }
    } // end accept action #41

Yytoken Accept_43()
    { // begin accept action #43
{
	StringBuilder sb = new StringBuilder("Illegal character: <");
	String s = yytext();
	for (int i = 0; i < s.Length; i++)
	  if (s[i] >= 32)
	    sb.Append(s[i]);
	  else
	    {
	    sb.Append("^");
	    sb.Append(Convert.ToChar(s[i]+'A'-1));
	    }
        sb.Append(">");
	Console.WriteLine(sb.ToString());	
	Utility.error(Utility.E_UNMATCHED);
        return null;
}
    } // end accept action #43

Yytoken Accept_44()
    { // begin accept action #44
{
	String str =  yytext().Substring(1,yytext().Length);
	Utility.error(Utility.E_UNCLOSEDSTR);
	Utility.assert(str.Length == yytext().Length - 1);
	return (new Yytoken(41,str,yyline,yychar,yychar + str.Length));
}
    } // end accept action #44

Yytoken Accept_45()
    { // begin accept action #45
{ return null; }
    } // end accept action #45

Yytoken Accept_47()
    { // begin accept action #47
{ return null; }
    } // end accept action #47

private const int YYINITIAL = 0;
private const int COMMENT = 1;
private static int[] yy_state_dtrans = new int[] 
  {   0,
  33
  };
private void yybegin (int state)
  {
  yy_lexical_state = state;
  }

private char yy_advance ()
  {
  int next_read;
  int i;
  int j;

  if (yy_buffer_index < yy_buffer_read)
    {
    return yy_buffer[yy_buffer_index++];
    }

  if (0 != yy_buffer_start)
    {
    i = yy_buffer_start;
    j = 0;
    while (i < yy_buffer_read)
      {
      yy_buffer[j] = yy_buffer[i];
      i++;
      j++;
      }
    yy_buffer_end = yy_buffer_end - yy_buffer_start;
    yy_buffer_start = 0;
    yy_buffer_read = j;
    yy_buffer_index = j;
    next_read = yy_reader.Read(yy_buffer,yy_buffer_read,
                  yy_buffer.Length - yy_buffer_read);
    if (next_read <= 0)
      {
      return (char) YY_EOF;
      }
    yy_buffer_read = yy_buffer_read + next_read;
    }
  while (yy_buffer_index >= yy_buffer_read)
    {
    if (yy_buffer_index >= yy_buffer.Length)
      {
      yy_buffer = yy_double(yy_buffer);
      }
    next_read = yy_reader.Read(yy_buffer,yy_buffer_read,
                  yy_buffer.Length - yy_buffer_read);
    if (next_read <= 0)
      {
      return (char) YY_EOF;
      }
    yy_buffer_read = yy_buffer_read + next_read;
    }
  return yy_buffer[yy_buffer_index++];
  }
private void yy_move_end ()
  {
  if (yy_buffer_end > yy_buffer_start && 
      '\n' == yy_buffer[yy_buffer_end-1])
    yy_buffer_end--;
  if (yy_buffer_end > yy_buffer_start &&
      '\r' == yy_buffer[yy_buffer_end-1])
    yy_buffer_end--;
  }
private bool yy_last_was_cr=false;
private void yy_mark_start ()
  {
  int i;
  for (i = yy_buffer_start; i < yy_buffer_index; i++)
    {
    if (yy_buffer[i] == '\n' && !yy_last_was_cr)
      {
      yyline++;
      }
    if (yy_buffer[i] == '\r')
      {
      yyline++;
      yy_last_was_cr=true;
      }
    else
      {
      yy_last_was_cr=false;
      }
    }
  yychar = yychar + yy_buffer_index - yy_buffer_start;
  yy_buffer_start = yy_buffer_index;
  }
private void yy_mark_end ()
  {
  yy_buffer_end = yy_buffer_index;
  }
private void yy_to_mark ()
  {
  yy_buffer_index = yy_buffer_end;
  yy_at_bol = (yy_buffer_end > yy_buffer_start) &&
    (yy_buffer[yy_buffer_end-1] == '\r' ||
    yy_buffer[yy_buffer_end-1] == '\n');
  }
internal string yytext()
  {
  return (new string(yy_buffer,
                yy_buffer_start,
                yy_buffer_end - yy_buffer_start)
         );
  }
private int yylength ()
  {
  return yy_buffer_end - yy_buffer_start;
  }
private char[] yy_double (char[] buf)
  {
  int i;
  char[] newbuf;
  newbuf = new char[2*buf.Length];
  for (i = 0; i < buf.Length; i++)
    {
    newbuf[i] = buf[i];
    }
  return newbuf;
  }
private const int YY_E_INTERNAL = 0;
private const int YY_E_MATCH = 1;
private static string[] yy_error_string = new string[]
  {
  "Error: Internal error.\n",
  "Error: Unmatched input.\n"
  };
private void yy_error (int code,bool fatal)
  {
  System.Console.Write(yy_error_string[code]);
  if (fatal)
    {
    throw new System.ApplicationException("Fatal Error.\n");
    }
  }
private static int[] yy_acpt = new int[]
  {
  /* 0 */   YY_NOT_ACCEPT,
  /* 1 */   YY_NO_ANCHOR,
  /* 2 */   YY_NO_ANCHOR,
  /* 3 */   YY_NO_ANCHOR,
  /* 4 */   YY_NO_ANCHOR,
  /* 5 */   YY_NO_ANCHOR,
  /* 6 */   YY_NO_ANCHOR,
  /* 7 */   YY_NO_ANCHOR,
  /* 8 */   YY_NO_ANCHOR,
  /* 9 */   YY_NO_ANCHOR,
  /* 10 */   YY_NO_ANCHOR,
  /* 11 */   YY_NO_ANCHOR,
  /* 12 */   YY_NO_ANCHOR,
  /* 13 */   YY_NO_ANCHOR,
  /* 14 */   YY_NO_ANCHOR,
  /* 15 */   YY_NO_ANCHOR,
  /* 16 */   YY_NO_ANCHOR,
  /* 17 */   YY_NO_ANCHOR,
  /* 18 */   YY_NO_ANCHOR,
  /* 19 */   YY_NO_ANCHOR,
  /* 20 */   YY_NO_ANCHOR,
  /* 21 */   YY_NO_ANCHOR,
  /* 22 */   YY_NO_ANCHOR,
  /* 23 */   YY_NO_ANCHOR,
  /* 24 */   YY_NO_ANCHOR,
  /* 25 */   YY_NO_ANCHOR,
  /* 26 */   YY_NO_ANCHOR,
  /* 27 */   YY_NO_ANCHOR,
  /* 28 */   YY_NO_ANCHOR,
  /* 29 */   YY_NO_ANCHOR,
  /* 30 */   YY_NO_ANCHOR,
  /* 31 */   YY_NO_ANCHOR,
  /* 32 */   YY_NO_ANCHOR,
  /* 33 */   YY_NO_ANCHOR,
  /* 34 */   YY_NO_ANCHOR,
  /* 35 */   YY_NO_ANCHOR,
  /* 36 */   YY_NOT_ACCEPT,
  /* 37 */   YY_NO_ANCHOR,
  /* 38 */   YY_NO_ANCHOR,
  /* 39 */   YY_NO_ANCHOR,
  /* 40 */   YY_NO_ANCHOR,
  /* 41 */   YY_NO_ANCHOR,
  /* 42 */   YY_NOT_ACCEPT,
  /* 43 */   YY_NO_ANCHOR,
  /* 44 */   YY_NO_ANCHOR,
  /* 45 */   YY_NO_ANCHOR,
  /* 46 */   YY_NOT_ACCEPT,
  /* 47 */   YY_NO_ANCHOR
  };
private static int[] yy_cmap = new int[]
  {
  23, 23, 23, 23, 23, 23, 23, 23,
  20, 20, 21, 23, 23, 22, 23, 23,
  23, 23, 23, 23, 23, 23, 23, 23,
  23, 23, 23, 23, 23, 23, 23, 23,
  20, 23, 25, 23, 23, 23, 18, 23,
  4, 5, 13, 11, 1, 12, 10, 14,
  27, 27, 27, 27, 27, 27, 27, 27,
  27, 27, 2, 3, 16, 15, 17, 24,
  23, 28, 28, 28, 28, 28, 28, 28,
  28, 28, 28, 28, 28, 28, 28, 28,
  28, 28, 28, 28, 28, 28, 28, 28,
  28, 28, 28, 6, 26, 7, 23, 29,
  23, 28, 28, 28, 28, 28, 28, 28,
  28, 28, 28, 28, 28, 28, 28, 28,
  28, 28, 28, 28, 28, 28, 28, 28,
  28, 28, 28, 8, 19, 9, 23, 23,
  0, 0 
  };
private static int[] yy_rmap = new int[]
  {
  0, 1, 1, 2, 1, 1, 1, 1,
  1, 1, 1, 1, 1, 1, 1, 3,
  1, 4, 5, 1, 1, 6, 1, 1,
  7, 8, 9, 1, 1, 1, 1, 1,
  1, 10, 1, 1, 11, 12, 13, 14,
  7, 12, 15, 16, 17, 18, 19, 20
  };
private static int[,] yy_nxt = new int[,]
  {
  { 1, 2, 3, 4, 5, 6, 7, 8,
   9, 10, 11, 12, 13, 14, 15, 16,
   17, 18, 19, 20, 21, 21, 22, 23,
   22, 24, 23, 25, 26, 23 },
  { -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1 },
  { -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, 27,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1 },
  { -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, 28, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1 },
  { -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, 29,
   -1, 30, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1 },
  { -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, 31,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1 },
  { -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, 21, 21, -1, -1,
   -1, -1, -1, -1, -1, -1 },
  { -1, 24, 24, 24, -1, -1, 24, 24,
   24, 24, 24, 24, 24, 24, 24, 24,
   24, 24, 24, -1, 24, -1, -1, 24,
   24, 32, 39, 24, 24, 24 },
  { -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, 25, -1, -1 },
  { -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, 26, 26, 26 },
  { 1, 41, 41, 41, 37, 37, 41, 41,
   41, 41, 41, 41, 41, 38, 43, 41,
   41, 41, 41, 37, 41, 22, 22, 41,
   37, 41, 41, 41, 41, 41 },
  { -1, -1, -1, -1, 36, 36, -1, -1,
   -1, -1, -1, -1, -1, -1, -1, -1,
   -1, -1, -1, 36, 36, 36, 36, -1,
   -1, -1, 24, -1, -1, -1 },
  { -1, 41, 41, 41, 41, 41, 41, 41,
   41, 41, 41, 41, 41, 42, 46, 41,
   41, 41, 41, 41, 41, -1, -1, 41,
   41, 41, 41, 41, 41, 41 },
  { -1, 41, 41, 41, 41, 41, 41, 41,
   41, 41, 41, 41, 41, 45, 34, 41,
   41, 41, 41, 41, 41, -1, -1, 41,
   41, 41, 41, 41, 41, 41 },
  { -1, 24, 24, 24, 36, 36, 24, 24,
   24, 24, 24, 24, 24, 24, 24, 24,
   24, 24, 24, 36, 44, 36, 36, 24,
   24, 40, 39, 24, 24, 24 },
  { -1, 41, 41, 41, 41, 41, 41, 41,
   41, 41, 41, 41, 41, 45, -1, 41,
   41, 41, 41, 41, 41, -1, -1, 41,
   41, 41, 41, 41, 41, 41 },
  { -1, 41, 41, 41, 41, 41, 41, 41,
   41, 41, 41, 41, 41, 35, 47, 41,
   41, 41, 41, 41, 41, -1, -1, 41,
   41, 41, 41, 41, 41, 41 },
  { -1, 24, 24, 24, 36, 36, 24, 24,
   24, 24, 24, 24, 24, 24, 24, 24,
   24, 24, 24, 36, 44, 36, 36, 24,
   24, 32, 39, 24, 24, 24 },
  { -1, 41, 41, 41, 41, 41, 41, 41,
   41, 41, 41, 41, 41, 45, 46, 41,
   41, 41, 41, 41, 41, -1, -1, 41,
   41, 41, 41, 41, 41, 41 },
  { -1, 41, 41, 41, 41, 41, 41, 41,
   41, 41, 41, 41, 41, -1, 47, 41,
   41, 41, 41, 41, 41, -1, -1, 41,
   41, 41, 41, 41, 41, 41 },
  { -1, 41, 41, 41, 41, 41, 41, 41,
   41, 41, 41, 41, 41, 42, 47, 41,
   41, 41, 41, 41, 41, -1, -1, 41,
   41, 41, 41, 41, 41, 41 }
  };
public Yytoken yylex()
  {
  char yy_lookahead;
  int yy_anchor = YY_NO_ANCHOR;
  int yy_state = yy_state_dtrans[yy_lexical_state];
  int yy_next_state = YY_NO_STATE;
  int yy_last_accept_state = YY_NO_STATE;
  bool yy_initial = true;
  int yy_this_accept;

  yy_mark_start();
  yy_this_accept = yy_acpt[yy_state];
  if (YY_NOT_ACCEPT != yy_this_accept)
    {
    yy_last_accept_state = yy_state;
    yy_mark_end();
    }
  while (true)
    {
    if (yy_initial && yy_at_bol)
      yy_lookahead = (char) YY_BOL;
    else
      {
      yy_lookahead = yy_advance();
      }
    yy_next_state = yy_nxt[yy_rmap[yy_state],yy_cmap[yy_lookahead]];
    if (YY_EOF == yy_lookahead && yy_initial)
      {
        return null;
      }
    if (YY_F != yy_next_state)
      {
      yy_state = yy_next_state;
      yy_initial = false;
      yy_this_accept = yy_acpt[yy_state];
      if (YY_NOT_ACCEPT != yy_this_accept)
        {
        yy_last_accept_state = yy_state;
        yy_mark_end();
        }
      }
    else
      {
      if (YY_NO_STATE == yy_last_accept_state)
        {
        throw new System.ApplicationException("Lexical Error: Unmatched Input.");
        }
      else
        {
        yy_anchor = yy_acpt[yy_last_accept_state];
        if (0 != (YY_END & yy_anchor))
          {
          yy_move_end();
          }
        yy_to_mark();
        if (yy_last_accept_state < 0)
          {
          if (yy_last_accept_state < 48)
            yy_error(YY_E_INTERNAL, false);
          }
        else
          {
          AcceptMethod m = accept_dispatch[yy_last_accept_state];
          if (m != null)
            {
            Yytoken tmp = m();
            if (tmp != null)
              return tmp;
            }
          }
        yy_initial = true;
        yy_state = yy_state_dtrans[yy_lexical_state];
        yy_next_state = YY_NO_STATE;
        yy_last_accept_state = YY_NO_STATE;
        yy_mark_start();
        yy_this_accept = yy_acpt[yy_state];
        if (YY_NOT_ACCEPT != yy_this_accept)
          {
          yy_last_accept_state = yy_state;
          yy_mark_end();
          }
        }
      }
    }
  }
}

}
