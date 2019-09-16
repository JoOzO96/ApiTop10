Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class GrupoController
        Inherits ApiController

        ' GET: api/Grupo
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Grupo/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Grupo
        Public Function PostValue(<FromBody()> ByVal value As String)
            If value IsNot Nothing Then


                Dim json = value.ToString
                Dim dados As New OleDbConnection
                Dim comando As New OleDbCommand
                Dim ds As New DataSet
                Dim exportacao = New Exportacao
                Dim insert As String
                Dim grupo = New Grupo
                Dim produto = New Produto
                Dim controleCodigo = New ControleCodigo
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
                    comando = New OleDbCommand("SELECT TOP 1 * from ExportacaoControle ORDER BY ID DESC", dados)
                    da = New OleDbDataAdapter(comando)
                    da.Fill(ds, "Exportacao")

                    'For j = 0 To listaexportacao(i).Grupos.Count - 1

                    '    grupo = listaexportacao(i).Grupos(j)
                    '    grupo.Idexportacao = ds.Tables(0).Rows(0)("id")
                    '    insert = RetornaInsert(fieldListGrupo, grupo, "ExportacaoGrupo")
                    '    insert = insert.Replace("códgrupo", "[Cód Grupo]")
                    '    insert = insert.Replace("comissão", "[Comissão]")
                    '    comando = New OleDbCommand(insert, dados)
                    '    numerodelinhas = comando.ExecuteNonQuery()

                    'Next

                    'For j = 0 To listaexportacao(i).Produtos.Count - 1

                    '    produto = listaexportacao(i).Produtos(j)
                    '    produto.idexportacao = ds.Tables(0).Rows(0)("id")
                    '    insert = RetornaInsert(fieldListProduto, produto, "ExportacaoProduto")
                    '    insert = insert.Replace("codproduto", "[Cod Produto]")
                    '    insert = insert.Replace("número,", "[Número],")
                    '    insert = insert.Replace("codfornecedor,", "[Cod Fornecedor],")
                    '    insert = insert.Replace("valorcompra,", "[Valor Compra],")
                    '    insert = insert.Replace("valoravista,", "[Valor Avista],")
                    '    insert = insert.Replace("valorprazo,", "[Valor Prazo],")
                    '    insert = insert.Replace("codgrupo,", "[Cod Grupo],")
                    '    insert = insert.Replace("codicms,", "[Cod Icms],")
                    '    insert = insert.Replace(",dificms,", ",[Dif ICMS],")
                    '    insert = insert.Replace("perprazo,", "[Per Prazo],")
                    '    insert = insert.Replace("códsubgrupo,", "[Cód SubGrupo],")
                    '    insert = insert.Replace("maximo,", "[Máximo],")
                    '    insert = insert.Replace("comissão,", "[Comissão],")
                    '    insert = insert.Replace("códpis,", "[CódPIS],")
                    '    insert = insert.Replace("códcofins,", "[CódCOFINS],")
                    '    insert = insert.Replace("códipi,", "[CódIPI],")
                    '    insert = insert.Replace("carência,", "[Carência],")
                    '    insert = insert.Replace("aplicação,", "[Aplicação],")
                    '    insert = insert.Replace("concentração,", "[Concentração],")
                    '    insert = insert.Replace("formulação,", "[Formulação],")
                    '    insert = insert.Replace("comentário,", "[Comentário],")
                    '    insert = insert.Replace("códsubgrupo,", "[CódSubGrupo],")
                    '    insert = insert.Replace("códpise,", "[CódPisE],")
                    '    insert = insert.Replace("códcofinse,", "[CódCOFINSE],")
                    '    insert = insert.Replace("códipise,", "[CódIPISE],")
                    '    insert = insert.Replace("máquina,", "[Máquina],")
                    '    insert = insert.Replace("códproduto,", "[Cód Produto],")
                    '    comando = New OleDbCommand(insert, dados)
                    '    numerodelinhas = comando.ExecuteNonQuery()

                    'Next

                Next
                dados.Close()

            End If

        End Function

        ' PUT: api/Grupo/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Grupo/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace