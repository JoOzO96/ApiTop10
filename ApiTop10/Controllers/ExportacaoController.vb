Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ExportacaoController
        Inherits ApiController

        ' GET: api/Exportacao
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Exportacao/5
        Public Function GetValue(ByVal id As String) As List(Of Exportacao)
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim exportacao = New Exportacao
            Dim insert As String
            Dim grupo = New Grupo
            Dim produto = New Produto
            Dim listaexportacao As New List(Of Exportacao)
            Dim dsGrupo As New DataSet
            Dim dsProduto As New DataSet
            Dim _grupo As New List(Of Grupo)
            Dim _produto As New List(Of Produto)
            Dim fieldListGrupo() = grupo.GetType().GetProperties
            Dim fieldListProduto() = produto.GetType().GetProperties
            Dim nomecampo As String
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from Exportacao WHERE CNPJDESTINO = '" & id & "' AND IMPORTADO = FALSE", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Exportacao")

            If ds.Tables(0).Rows.Count > 0 Then
                exportacao.Cnpjdestino = ds.Tables(0).Rows(0)("CNPJDESTINO")
                exportacao.Cnpjemitente = ds.Tables(0).Rows(0)("CNPJEMITENTE")
                exportacao.Computador = ds.Tables(0).Rows(0)("COMPUTADOR")
                exportacao.Data = ds.Tables(0).Rows(0)("data")
                comando = New OleDbCommand("SELECT * from ExportacaoGrupo WHERE idexportacao = " & ds.Tables(0).Rows(0)("id"), dados)
                da = New OleDbDataAdapter(comando)
                da.Fill(dsGrupo, "Exportacao")

                If dsGrupo.Tables(0).Rows.Count > 0 Then

                    For i = 0 To dsGrupo.Tables(0).Rows.Count - 1
                        grupo = New Grupo

                        For j = 0 To fieldListGrupo.Length - 1
                            nomecampo = fieldListGrupo(j).Name.ToLower
                            If Not nomecampo.Equals("cadastroandroid") And Not nomecampo.Equals("alteradoandroid") Then
                                If (nomecampo.Equals("códgrupo")) Then
                                    nomecampo = "Cód Grupo"
                                End If
                                If Not IsDBNull(dsGrupo.Tables(0).Rows(i)(nomecampo)) Then
                                    grupo = colocaDadosObjeto(grupo, fieldListGrupo(j), dsGrupo.Tables(0).Rows(i)(nomecampo))
                                End If
                            End If
                        Next
                        _grupo.Add(grupo)

                    Next
                End If
                comando = New OleDbCommand("SELECT * from ExportacaoProduto WHERE idexportacao = " & ds.Tables(0).Rows(0)("id"), dados)
                da = New OleDbDataAdapter(comando)
                da.Fill(dsProduto, "ExportacaoProduto")

                If dsProduto.Tables(0).Rows.Count > 0 Then

                    For i = 0 To dsProduto.Tables(0).Rows.Count - 1
                        produto = New Produto

                        For j = 0 To fieldListProduto.Length - 1
                            nomecampo = fieldListProduto(j).Name.ToLower
                            If Not nomecampo.Equals("cadastroandroid") And Not nomecampo.Equals("alteradoandroid") Then
                                If (nomecampo.Equals("codproduto")) Then
                                    nomecampo = "Cod Produto"
                                ElseIf (nomecampo.Equals("codfornecedor")) Then
                                    nomecampo = "Cod Fornecedor"
                                ElseIf (nomecampo.Equals("valorcompra")) Then
                                    nomecampo = "Valor Compra"
                                ElseIf (nomecampo.Equals("valoravista")) Then
                                    nomecampo = "Valor Avista"
                                ElseIf (nomecampo.Equals("valorprazo")) Then
                                    nomecampo = "Valor Prazo"
                                ElseIf (nomecampo.Equals("codgrupo")) Then
                                    nomecampo = "Cod Grupo"
                                ElseIf (nomecampo.Equals("codicms")) Then
                                    nomecampo = "Cod Icms"
                                ElseIf (nomecampo.Equals("dificms")) Then
                                    nomecampo = "Dif ICMS"
                                ElseIf (nomecampo.Equals("perprazo")) Then
                                    nomecampo = "Per Prazo"
                                ElseIf (nomecampo.Equals("codpis")) Then
                                    nomecampo = "códPIS"
                                ElseIf (nomecampo.Equals("codcofins")) Then
                                    nomecampo = "CódCOFINS"
                                ElseIf (nomecampo.Equals("codcofinse")) Then
                                    nomecampo = "códCOFINSE"
                                ElseIf (nomecampo.Equals("codipi")) Then
                                    nomecampo = "CódIPI"
                                ElseIf (nomecampo.Equals("carencia")) Then
                                    nomecampo = "carência"
                                ElseIf (nomecampo.Equals("aplicacao")) Then
                                    nomecampo = "Aplicação"
                                ElseIf (nomecampo.Equals("concentracao")) Then
                                    nomecampo = "Concentração"
                                ElseIf (nomecampo.Equals("formulacao")) Then
                                    nomecampo = "Formulação"
                                ElseIf (nomecampo.Equals("comentario")) Then
                                    nomecampo = "Comentário"
                                ElseIf (nomecampo.Equals("codsubgrupo")) Then
                                    nomecampo = "CódSubGrupo"
                                ElseIf (nomecampo.Equals("maximo")) Then
                                    nomecampo = "máximo"
                                ElseIf (nomecampo.Equals("codpise")) Then
                                    nomecampo = "CódPisE"
                                ElseIf (nomecampo.Equals("codipise")) Then
                                    nomecampo = "CódIPISE"
                                ElseIf (nomecampo.Equals("comissao")) Then
                                    nomecampo = "Comissão"
                                ElseIf (nomecampo.Equals("maquina")) Then
                                    nomecampo = "máquina"
                                End If
                                If Not IsDBNull(dsProduto.Tables(0).Rows(i)(nomecampo)) Then
                                    produto = colocaDadosObjeto(produto, fieldListProduto(j), dsProduto.Tables(0).Rows(i)(nomecampo))
                                End If
                            End If
                        Next
                        _produto.Add(produto)

                    Next
                End If
                comando = New OleDbCommand("UPDATE EXPORTACAO SET IMPORTADO = TRUE WHERE ID = " & ds.Tables(0).Rows(0)("id"), dados)
                comando.ExecuteNonQuery()
            End If


            exportacao.Grupos = _grupo
            exportacao.Produtos = _produto
            listaexportacao.Add(exportacao)
            Return listaexportacao
        End Function

        ' POST: api/Exportacao
        Public Sub PostValue(<FromBody()> ByVal value As Object)
            If value IsNot Nothing Then


                Dim json = value.ToString
                Dim dados As New OleDbConnection
                Dim comando As New OleDbCommand
                Dim ds As New DataSet
                Dim exportacao = New Exportacao
                Dim insert As String
                Dim grupo = New Grupo
                Dim produto = New Produto
                Dim listaexportacao As List(Of Exportacao)
                listaexportacao = JsonConvert.DeserializeObject(Of List(Of Exportacao))(json)

                dados.ConnectionString = RetornaConexao()
                dados.Open()
                comando = New OleDbCommand("SELECT * from Exportacao", dados)
                Dim da As New OleDbDataAdapter(comando)
                da.Fill(ds, "Exportacao")
                Dim fieldList = exportacao.GetType().GetProperties().ToList
                Dim fieldListGrupo = grupo.GetType().GetProperties().ToList
                Dim fieldListProduto = produto.GetType().GetProperties().ToList
                For i = 0 To listaexportacao.Count - 1
                    exportacao = New Exportacao
                    exportacao = listaexportacao(i)
                    insert = RetornaInsert(fieldList, exportacao, "Exportacao")

                    comando = New OleDbCommand(insert, dados)

                    Dim numerodelinhas = comando.ExecuteNonQuery()
                    ds = Nothing
                    ds = New DataSet
                    comando = New OleDbCommand("SELECT TOP 1 * from Exportacao ORDER BY ID DESC", dados)
                    da = New OleDbDataAdapter(comando)
                    da.Fill(ds, "Exportacao")

                    For j = 0 To listaexportacao(i).Grupos.Count - 1

                        grupo = listaexportacao(i).Grupos(j)
                        grupo.Idexportacao = ds.Tables(0).Rows(0)("id")
                        insert = RetornaInsert(fieldListGrupo, grupo, "ExportacaoGrupo")
                        insert = insert.Replace("códgrupo", "[Cód Grupo]")
                        insert = insert.Replace("comissão", "[Comissão]")
                        comando = New OleDbCommand(insert, dados)
                        numerodelinhas = comando.ExecuteNonQuery()

                    Next

                    For j = 0 To listaexportacao(i).Produtos.Count - 1

                        produto = listaexportacao(i).Produtos(j)
                        produto.idexportacao = ds.Tables(0).Rows(0)("id")
                        insert = RetornaInsert(fieldListProduto, produto, "ExportacaoProduto")
                        insert = insert.Replace("codproduto", "[Cod Produto]")
                        insert = insert.Replace("número,", "[Número],")
                        insert = insert.Replace("codfornecedor,", "[Cod Fornecedor],")
                        insert = insert.Replace("valorcompra,", "[Valor Compra],")
                        insert = insert.Replace("valoravista,", "[Valor Avista],")
                        insert = insert.Replace("valorprazo,", "[Valor Prazo],")
                        insert = insert.Replace("codgrupo,", "[Cod Grupo],")
                        insert = insert.Replace("codicms,", "[Cod Icms],")
                        insert = insert.Replace(",dificms,", ",[Dif ICMS],")
                        insert = insert.Replace("perprazo,", "[Per Prazo],")
                        insert = insert.Replace("códsubgrupo,", "[Cód SubGrupo],")
                        insert = insert.Replace("maximo,", "[Máximo],")
                        insert = insert.Replace("comissão,", "[Comissão],")
                        insert = insert.Replace("códpis,", "[CódPIS],")
                        insert = insert.Replace("códcofins,", "[CódCOFINS],")
                        insert = insert.Replace("códipi,", "[CódIPI],")
                        insert = insert.Replace("carência,", "[Carência],")
                        insert = insert.Replace("aplicação,", "[Aplicação],")
                        insert = insert.Replace("concentração,", "[Concentração],")
                        insert = insert.Replace("formulação,", "[Formulação],")
                        insert = insert.Replace("comentário,", "[Comentário],")
                        insert = insert.Replace("códsubgrupo,", "[CódSubGrupo],")
                        insert = insert.Replace("códpise,", "[CódPisE],")
                        insert = insert.Replace("códcofinse,", "[CódCOFINSE],")
                        insert = insert.Replace("códipise,", "[CódIPISE],")
                        insert = insert.Replace("máquina,", "[Máquina],")
                        insert = insert.Replace("códproduto,", "[Cód Produto],")
                        comando = New OleDbCommand(insert, dados)
                        numerodelinhas = comando.ExecuteNonQuery()

                    Next
                Next

                dados.Close()
            End If
        End Sub

        ' PUT: api/Exportacao/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Exportacao/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace