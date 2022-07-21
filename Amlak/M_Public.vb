Imports vb = Microsoft.VisualBasic

Module M_Public

    Enum LT
        _New
        _Edit
    End Enum

    Enum Edit
        Afrad_Momayezi
        Derakht
        Mahiyat_Fiziki
        Moshakhasat_Avalieh
        Moshakhasat_Eshterak
        Moshakhasat_Malekin
        Moshakhasat_Momayezi
        Moshakhasat_Sakhteman
        Moshakhasat_Zamin
        No_Estefadeh
        Tamlak
    End Enum

    Enum Takmil
        Yes
        No
    End Enum


    Public _Codeblock As New System.Nullable(Of Byte)
    Public _CodeFard As String
    Public _Shomareh_Shenasnameh As String
    Public _Load_Type As LT
    Public _Edit_Forms As Edit
    Public _Takmil As Takmil

    Public _insert As New DB_NoSaziDataSetTableAdapters.QueriesTableAdapter
    Public _Update As New DB_NoSaziDataSetTableAdapters.QueriesTableAdapter

    Public _DBL As Sqldblayer.Dblayer



    Function Max_Radif(ByVal DataGrid As DataGridView) As Byte

        Dim max As Byte = 0
        For index As Integer = 0 To DataGrid.Rows.Count - 1

            If max <= DataGrid.Rows(index).Cells(0).Value Then
                max = DataGrid.Rows(index).Cells(0).Value
            End If

        Next
        Return max

    End Function

    Public Function NUM_TO_STR(ByRef x As String) As String

        Dim one(10) As String
        Dim two(10) As String
        Dim Three(10) As String
        Dim Hundred(10) As String
        Dim Thousand As String
        Dim lakh As String
        Dim Crore As String
        Dim Billion As String
        Dim Million As String
        Dim Trillion As String

        'www.mahyarfaq.blogfa.com


        one(0) = "صفر" : one(1) = "یک" : one(2) = "دو" : one(3) = "سه" : one(4) = "چهار"
        one(5) = "پنج" : one(6) = "شش" : one(7) = "هفت" : one(8) = "هشت" : one(9) = "نه"

        two(0) = "ده" : two(1) = "یازده" : two(2) = "دوازده" : two(3) = "سیزده" : two(4) = "چهارده"
        two(5) = "پانزده" : two(6) = "شانزده" : two(7) = "هفده" : two(8) = "هیجده" : two(9) = "نوزده"

        Three(2) = "بیست" : Three(3) = "سی" : Three(4) = "چهل" : Three(5) = "پنجاه"
        Three(6) = "شصت" : Three(7) = "هفتاد" : Three(8) = "هشتاد" : Three(9) = "نود"

        Hundred(1) = "یکصد" : Hundred(2) = "دویست" : Hundred(3) = "سیصد"
        Hundred(4) = "چهارصد" : Hundred(5) = "پانصد" : Hundred(6) = "ششصد"
        Hundred(7) = "هفتصد" : Hundred(8) = "هشتصد" : Hundred(9) = "نه صد"

        Thousand = "هزار" : lakh = " هزار" : Crore = " میلیون" : Billion = "میلیارد"
        Million = "میلیون" : Trillion = "تریلیون"

        Dim inp, RetVal As String

        inp = CStr(Val(x))
        'www.mahyarfaq.blogfa.com
        Select Case Len(inp)
            Case 1
                If x <> "" Then RetVal = one(CInt(x))
            Case 2
                If Int(CDbl(vb.Right(inp, 1))) > 0 And CDbl(vb.Left(inp, 1)) > 1 Then RetVal = " و " & NUM_TO_STR(CStr(Int(CDbl(vb.Right(inp, 1)))))

                If CDbl(vb.Left(inp, 1)) > 1 Then RetVal = Three(CInt(vb.Left(inp, 1))) & RetVal

                If CDbl(vb.Left(inp, 1)) = 1 Then RetVal = two(CInt(vb.Right(inp, 1)))

            Case 3
                If Int(CDbl(vb.Right(inp, 2))) > 0 Then RetVal = " و " & NUM_TO_STR(CStr(Int(CDbl(vb.Right(inp, 2)))))
                RetVal = Hundred(Int(CDbl(vb.Left(inp, 1)))) & RetVal
            Case 4
                If Int(CDbl(vb.Right(inp, 3))) > 0 Then RetVal = " و " & _
              NUM_TO_STR(CStr(Int(CDbl(vb.Right(inp, 3)))))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 1)))) & Thousand & RetVal
            Case 5
                If Int(CDbl(vb.Right(inp, 3))) > 0 Then RetVal = " و " & NUM_TO_STR(CStr(Int(CDbl(vb.Right(inp, 3)))))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 2)))) & Thousand & RetVal
            Case 6
                If CInt(vb.Right(inp, 5)) = 0 Then
                    RetVal = Hundred(Int(CDbl(vb.Left(inp, 1)))) & lakh
                Else
                    If CInt(vb.Right(inp, 3)) > 0 Then RetVal = " و " & NUM_TO_STR(CStr(CInt(vb.Right(inp, 3))))

                    RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 3)))) & lakh & RetVal
                End If
            Case 7
                If CInt(vb.Right(inp, 6)) > 0 Then RetVal = " و " & NUM_TO_STR(CStr(CInt(vb.Right(inp, 6))))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 1)))) & Crore & RetVal
            Case 8
                If CInt(vb.Right(inp, 6)) > 0 Then RetVal = " و " & NUM_TO_STR(CStr(CInt(vb.Right(inp, 6))))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 2)))) & Crore & RetVal
            Case 9
                If CInt(vb.Right(inp, 6)) > 0 Then RetVal = " و " & NUM_TO_STR(CStr(CInt(vb.Right(inp, 6))))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 3)))) & Crore & RetVal
            Case 10
                If CInt(vb.Right(inp, 9)) > 0 Then RetVal = " و " & NUM_TO_STR(CStr(CInt(vb.Right(inp, 9))))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 1)))) & Billion & RetVal
            Case 11
                If CInt(vb.Right(inp, 9)) > 0 Then RetVal = " و " & NUM_TO_STR(CStr(CInt(vb.Right(inp, 9))))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 2)))) & Billion & RetVal
            Case 12
                If Val(vb.Right(inp, 9)) > 0 Then RetVal = " و " & NUM_TO_STR(vb.Right(inp, 9))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 3)))) & Million & RetVal
            Case 13
                If Val(vb.Right(inp, 12)) > 0 Then RetVal = " و " & NUM_TO_STR(vb.Right(inp, 12))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 1)))) & Million & RetVal
            Case 14
                If Val(vb.Right(inp, 12)) > 0 Then RetVal = " و " & NUM_TO_STR(vb.Right(inp, 12))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 2)))) & Trillion & RetVal
            Case 15
                If Val(vb.Right(inp, 12)) > 0 Then RetVal = " و " & NUM_TO_STR(vb.Right(inp, 12))
                RetVal = NUM_TO_STR(Int(CDbl(vb.Left(inp, 3)))) & Trillion & RetVal
        End Select
        NUM_TO_STR = " " & RetVal & " "
        NUM_TO_STR = Replace(NUM_TO_STR, "  ", " ")
    End Function




End Module
