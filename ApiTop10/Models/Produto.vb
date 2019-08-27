Public Class Produto
    Private _codproduto As String
    Private _mercadoria As String
    Private _prateleira As String
    Private _número As String
    Private _unid As String
    Private _valorcompra As Decimal
    Private _valoravista As Decimal
    Private _valorprazo As Decimal
    Private _codgrupo As String
    Private _quantidade As Double
    Private _sittrib As String
    Private _codicms As String
    Private _frete As Double
    Private _dificms As Double
    Private _ipi As Double
    Private _divisao As Double
    Private _minimo As Double
    Private _peso As Double
    Private _total As Decimal
    Private _custo As Decimal
    Private _perprazo As Double
    Private _desconto As Double
    Private _descobal As Double
    Private _códsubgrupo As String
    Private _máximo As Double
    Private _custo1 As Decimal
    Private _cusope As Double
    Private _compra As Boolean
    Private _comissão As Double
    Private _máquina As Boolean
    Private _ncm As String
    Private _genero As String
    Private _mva As Double
    Private _redu As Double
    Private _códpis As String
    Private _cstpis As String
    Private _porpis As Double
    Private _vpis As Decimal
    Private _códcofins As String
    Private _cstcofins As String
    Private _porcofins As Double
    Private _vcofins As Decimal
    Private _códipi As String
    Private _ean As String
    Private _tamanho As String
    Private _letras As String
    Private _cfop As String
    Private _datacad As Date
    Private _datacompra As Date
    Private _datavenda As Date
    Private _inativo As Boolean
    Private _anp As String
    Private _codifeanp As String
    Private _aliqcide As Decimal
    Private _infadicionais As String
    Private _infespecifica As String
    Private _conversao As String
    Private _conversao1 As String
    Private _conversao2 As String
    Private _dosagem As String
    Private _aplicação As String
    Private _equipamento As String
    Private _fitoxidade As String
    Private _área As String
    Private _quanti As String
    Private _carência As String
    Private _reentrada As String
    Private _toxidade As String
    Private _obs As String
    Private _embala As String
    Private _ativo As String
    Private _formulação As String
    Private _concentração As String
    Private _classe As String
    Private _comentário As String
    Private _pesoc As Double
    Private _vaca As Boolean
    Private _mvafora As Double
    Private _obsproduto As String
    Private _numero As String
    Private _códpise As String
    Private _cstpise As String
    Private _porpise As Double
    Private _vpise As Decimal
    Private _códcofinse As String
    Private _cstcofinse As String
    Private _porcofinse As Double
    Private _vcofinse As Decimal
    Private _códipise As String
    Private _porsub As Double
    Private _codeauto As Boolean
    Private _codemitente As Long
    Private _vsubsti As Decimal
    Private _taxafora As Double
    Private _vfrete As Decimal
    Private _perconsumidor As Decimal
    Private _valorconsumidor As Decimal
    Private _veiculo As Boolean
    Private _placa As String
    Private _ano As String
    Private _cor As String
    Private _modelo As String
    Private _marca As String
    Private _despesas As Decimal
    Private _numeroori As String
    Private _dataalte As Date
    Private _montapedido As Boolean
    Private _valodificms As Decimal
    Private _valoipi As Decimal
    Private _vimpsimples As Decimal
    Private _markup As Decimal
    Private _custoimpostos As Decimal
    Private _porsimples As Double
    Private _chassis As String
    Private _renavan As String
    Private _locregistro As String
    Private _codcest As String
    Private _quantidadeconversao As Double
    Private _produtoconversao As Boolean
    Private _produtotanque As Boolean
    Private _valortaxa As Decimal
    Private _anomodelo As String
    Private _combustivel As String
    Private _imposobrelucro As Double
    Private _custosobrelucro As Decimal
    Private _especietipo As String
    Private _produtonaofiscal As Boolean
    Private _produtocereais As Boolean
    Private _produtotrigo As Boolean
    Private _datavencimentoprocuracao As Date
    Private _tortasoja As Boolean
    Private _oleosoja As Boolean
    Private _codmapa As String
    Private _codunidade As String
    Private _custozepel As Double
    Private _descanp As String
    Private _unitributacao As String
    Private _atualizado As Boolean
    Private _servicoatividade As Long
    Private _servicosubatividade As Long
    Private _quantidadefilial As Double
    Private _forabalanco As Boolean
    Private _nfecompra As String
    Private _volumesiga As Double
    Private _forasiga As Boolean
    Private _vbcstret As Double
    Private _pst As Double
    Private _vicmsstret As Double
    Private _vbcfcpstret As Double
    Private _pfcpstret As Double
    Private _predbcefet As Double
    Private _vbcefet As Double
    Private _picmsefet As Double
    Private _vicmsefet As Double
    Private _origem As String
    Private _letra As String
    Private _codfornecedor As String
    Private _idexportacao As Long

    Public Property codproduto As String
        Get
            Return _codproduto
        End Get
        Set(value As String)
            _codproduto = value
        End Set
    End Property

    Public Property mercadoria As String
        Get
            Return _mercadoria
        End Get
        Set(value As String)
            _mercadoria = value
        End Set
    End Property

    Public Property prateleira As String
        Get
            Return _prateleira
        End Get
        Set(value As String)
            _prateleira = value
        End Set
    End Property

    Public Property número As String
        Get
            Return _número
        End Get
        Set(value As String)
            _número = value
        End Set
    End Property

    Public Property unid As String
        Get
            Return _unid
        End Get
        Set(value As String)
            _unid = value
        End Set
    End Property

    Public Property valorcompra As Decimal
        Get
            Return _valorcompra
        End Get
        Set(value As Decimal)
            _valorcompra = value
        End Set
    End Property

    Public Property valoravista As Decimal
        Get
            Return _valoravista
        End Get
        Set(value As Decimal)
            _valoravista = value
        End Set
    End Property

    Public Property valorprazo As Decimal
        Get
            Return _valorprazo
        End Get
        Set(value As Decimal)
            _valorprazo = value
        End Set
    End Property

    Public Property codgrupo As String
        Get
            Return _codgrupo
        End Get
        Set(value As String)
            _codgrupo = value
        End Set
    End Property

    Public Property quantidade As Double
        Get
            Return _quantidade
        End Get
        Set(value As Double)
            _quantidade = value
        End Set
    End Property

    Public Property sittrib As String
        Get
            Return _sittrib
        End Get
        Set(value As String)
            _sittrib = value
        End Set
    End Property

    Public Property codicms As String
        Get
            Return _codicms
        End Get
        Set(value As String)
            _codicms = value
        End Set
    End Property

    Public Property frete As Double
        Get
            Return _frete
        End Get
        Set(value As Double)
            _frete = value
        End Set
    End Property

    Public Property dificms As Double
        Get
            Return _dificms
        End Get
        Set(value As Double)
            _dificms = value
        End Set
    End Property

    Public Property ipi As Double
        Get
            Return _ipi
        End Get
        Set(value As Double)
            _ipi = value
        End Set
    End Property

    Public Property divisao As Double
        Get
            Return _divisao
        End Get
        Set(value As Double)
            _divisao = value
        End Set
    End Property

    Public Property minimo As Double
        Get
            Return _minimo
        End Get
        Set(value As Double)
            _minimo = value
        End Set
    End Property

    Public Property peso As Double
        Get
            Return _peso
        End Get
        Set(value As Double)
            _peso = value
        End Set
    End Property

    Public Property total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property

    Public Property custo As Decimal
        Get
            Return _custo
        End Get
        Set(value As Decimal)
            _custo = value
        End Set
    End Property

    Public Property perprazo As Double
        Get
            Return _perprazo
        End Get
        Set(value As Double)
            _perprazo = value
        End Set
    End Property

    Public Property desconto As Double
        Get
            Return _desconto
        End Get
        Set(value As Double)
            _desconto = value
        End Set
    End Property

    Public Property descobal As Double
        Get
            Return _descobal
        End Get
        Set(value As Double)
            _descobal = value
        End Set
    End Property

    Public Property códsubgrupo As String
        Get
            Return _códsubgrupo
        End Get
        Set(value As String)
            _códsubgrupo = value
        End Set
    End Property

    Public Property máximo As Double
        Get
            Return _máximo
        End Get
        Set(value As Double)
            _máximo = value
        End Set
    End Property

    Public Property custo1 As Decimal
        Get
            Return _custo1
        End Get
        Set(value As Decimal)
            _custo1 = value
        End Set
    End Property

    Public Property cusope As Double
        Get
            Return _cusope
        End Get
        Set(value As Double)
            _cusope = value
        End Set
    End Property

    Public Property compra As Boolean
        Get
            Return _compra
        End Get
        Set(value As Boolean)
            _compra = value
        End Set
    End Property

    Public Property comissão As Double
        Get
            Return _comissão
        End Get
        Set(value As Double)
            _comissão = value
        End Set
    End Property

    Public Property máquina As Boolean
        Get
            Return _máquina
        End Get
        Set(value As Boolean)
            _máquina = value
        End Set
    End Property

    Public Property ncm As String
        Get
            Return _ncm
        End Get
        Set(value As String)
            _ncm = value
        End Set
    End Property

    Public Property genero As String
        Get
            Return _genero
        End Get
        Set(value As String)
            _genero = value
        End Set
    End Property

    Public Property mva As Double
        Get
            Return _mva
        End Get
        Set(value As Double)
            _mva = value
        End Set
    End Property

    Public Property redu As Double
        Get
            Return _redu
        End Get
        Set(value As Double)
            _redu = value
        End Set
    End Property

    Public Property códpis As String
        Get
            Return _códpis
        End Get
        Set(value As String)
            _códpis = value
        End Set
    End Property

    Public Property cstpis As String
        Get
            Return _cstpis
        End Get
        Set(value As String)
            _cstpis = value
        End Set
    End Property

    Public Property porpis As Double
        Get
            Return _porpis
        End Get
        Set(value As Double)
            _porpis = value
        End Set
    End Property

    Public Property vpis As Decimal
        Get
            Return _vpis
        End Get
        Set(value As Decimal)
            _vpis = value
        End Set
    End Property

    Public Property códcofins As String
        Get
            Return _códcofins
        End Get
        Set(value As String)
            _códcofins = value
        End Set
    End Property

    Public Property cstcofins As String
        Get
            Return _cstcofins
        End Get
        Set(value As String)
            _cstcofins = value
        End Set
    End Property

    Public Property porcofins As Double
        Get
            Return _porcofins
        End Get
        Set(value As Double)
            _porcofins = value
        End Set
    End Property

    Public Property vcofins As Decimal
        Get
            Return _vcofins
        End Get
        Set(value As Decimal)
            _vcofins = value
        End Set
    End Property

    Public Property códipi As String
        Get
            Return _códipi
        End Get
        Set(value As String)
            _códipi = value
        End Set
    End Property

    Public Property ean As String
        Get
            Return _ean
        End Get
        Set(value As String)
            _ean = value
        End Set
    End Property

    Public Property tamanho As String
        Get
            Return _tamanho
        End Get
        Set(value As String)
            _tamanho = value
        End Set
    End Property

    Public Property letras As String
        Get
            Return _letras
        End Get
        Set(value As String)
            _letras = value
        End Set
    End Property

    Public Property cfop As String
        Get
            Return _cfop
        End Get
        Set(value As String)
            _cfop = value
        End Set
    End Property

    Public Property datacad As Date
        Get
            Return _datacad
        End Get
        Set(value As Date)
            _datacad = value
        End Set
    End Property

    Public Property datacompra As Date
        Get
            Return _datacompra
        End Get
        Set(value As Date)
            _datacompra = value
        End Set
    End Property

    Public Property datavenda As Date
        Get
            Return _datavenda
        End Get
        Set(value As Date)
            _datavenda = value
        End Set
    End Property

    Public Property inativo As Boolean
        Get
            Return _inativo
        End Get
        Set(value As Boolean)
            _inativo = value
        End Set
    End Property

    Public Property anp As String
        Get
            Return _anp
        End Get
        Set(value As String)
            _anp = value
        End Set
    End Property

    Public Property codifeanp As String
        Get
            Return _codifeanp
        End Get
        Set(value As String)
            _codifeanp = value
        End Set
    End Property

    Public Property aliqcide As Decimal
        Get
            Return _aliqcide
        End Get
        Set(value As Decimal)
            _aliqcide = value
        End Set
    End Property

    Public Property infadicionais As String
        Get
            Return _infadicionais
        End Get
        Set(value As String)
            _infadicionais = value
        End Set
    End Property

    Public Property infespecifica As String
        Get
            Return _infespecifica
        End Get
        Set(value As String)
            _infespecifica = value
        End Set
    End Property

    Public Property conversao As String
        Get
            Return _conversao
        End Get
        Set(value As String)
            _conversao = value
        End Set
    End Property

    Public Property conversao1 As String
        Get
            Return _conversao1
        End Get
        Set(value As String)
            _conversao1 = value
        End Set
    End Property

    Public Property conversao2 As String
        Get
            Return _conversao2
        End Get
        Set(value As String)
            _conversao2 = value
        End Set
    End Property

    Public Property dosagem As String
        Get
            Return _dosagem
        End Get
        Set(value As String)
            _dosagem = value
        End Set
    End Property

    Public Property aplicação As String
        Get
            Return _aplicação
        End Get
        Set(value As String)
            _aplicação = value
        End Set
    End Property

    Public Property equipamento As String
        Get
            Return _equipamento
        End Get
        Set(value As String)
            _equipamento = value
        End Set
    End Property

    Public Property fitoxidade As String
        Get
            Return _fitoxidade
        End Get
        Set(value As String)
            _fitoxidade = value
        End Set
    End Property

    Public Property área As String
        Get
            Return _área
        End Get
        Set(value As String)
            _área = value
        End Set
    End Property

    Public Property quanti As String
        Get
            Return _quanti
        End Get
        Set(value As String)
            _quanti = value
        End Set
    End Property

    Public Property carência As String
        Get
            Return _carência
        End Get
        Set(value As String)
            _carência = value
        End Set
    End Property

    Public Property reentrada As String
        Get
            Return _reentrada
        End Get
        Set(value As String)
            _reentrada = value
        End Set
    End Property

    Public Property toxidade As String
        Get
            Return _toxidade
        End Get
        Set(value As String)
            _toxidade = value
        End Set
    End Property

    Public Property obs As String
        Get
            Return _obs
        End Get
        Set(value As String)
            _obs = value
        End Set
    End Property

    Public Property embala As String
        Get
            Return _embala
        End Get
        Set(value As String)
            _embala = value
        End Set
    End Property

    Public Property ativo As String
        Get
            Return _ativo
        End Get
        Set(value As String)
            _ativo = value
        End Set
    End Property

    Public Property formulação As String
        Get
            Return _formulação
        End Get
        Set(value As String)
            _formulação = value
        End Set
    End Property

    Public Property concentração As String
        Get
            Return _concentração
        End Get
        Set(value As String)
            _concentração = value
        End Set
    End Property

    Public Property classe As String
        Get
            Return _classe
        End Get
        Set(value As String)
            _classe = value
        End Set
    End Property

    Public Property comentário As String
        Get
            Return _comentário
        End Get
        Set(value As String)
            _comentário = value
        End Set
    End Property

    Public Property pesoc As Double
        Get
            Return _pesoc
        End Get
        Set(value As Double)
            _pesoc = value
        End Set
    End Property

    Public Property vaca As Boolean
        Get
            Return _vaca
        End Get
        Set(value As Boolean)
            _vaca = value
        End Set
    End Property

    Public Property mvafora As Double
        Get
            Return _mvafora
        End Get
        Set(value As Double)
            _mvafora = value
        End Set
    End Property

    Public Property obsproduto As String
        Get
            Return _obsproduto
        End Get
        Set(value As String)
            _obsproduto = value
        End Set
    End Property

    Public Property numero As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property

    Public Property códpise As String
        Get
            Return _códpise
        End Get
        Set(value As String)
            _códpise = value
        End Set
    End Property

    Public Property cstpise As String
        Get
            Return _cstpise
        End Get
        Set(value As String)
            _cstpise = value
        End Set
    End Property

    Public Property porpise As Double
        Get
            Return _porpise
        End Get
        Set(value As Double)
            _porpise = value
        End Set
    End Property

    Public Property vpise As Decimal
        Get
            Return _vpise
        End Get
        Set(value As Decimal)
            _vpise = value
        End Set
    End Property

    Public Property códcofinse As String
        Get
            Return _códcofinse
        End Get
        Set(value As String)
            _códcofinse = value
        End Set
    End Property

    Public Property cstcofinse As String
        Get
            Return _cstcofinse
        End Get
        Set(value As String)
            _cstcofinse = value
        End Set
    End Property

    Public Property porcofinse As Double
        Get
            Return _porcofinse
        End Get
        Set(value As Double)
            _porcofinse = value
        End Set
    End Property

    Public Property vcofinse As Decimal
        Get
            Return _vcofinse
        End Get
        Set(value As Decimal)
            _vcofinse = value
        End Set
    End Property

    Public Property códipise As String
        Get
            Return _códipise
        End Get
        Set(value As String)
            _códipise = value
        End Set
    End Property

    Public Property porsub As Double
        Get
            Return _porsub
        End Get
        Set(value As Double)
            _porsub = value
        End Set
    End Property

    Public Property codeauto As Boolean
        Get
            Return _codeauto
        End Get
        Set(value As Boolean)
            _codeauto = value
        End Set
    End Property

    Public Property codemitente As Long
        Get
            Return _codemitente
        End Get
        Set(value As Long)
            _codemitente = value
        End Set
    End Property

    Public Property vsubsti As Decimal
        Get
            Return _vsubsti
        End Get
        Set(value As Decimal)
            _vsubsti = value
        End Set
    End Property

    Public Property taxafora As Double
        Get
            Return _taxafora
        End Get
        Set(value As Double)
            _taxafora = value
        End Set
    End Property

    Public Property vfrete As Decimal
        Get
            Return _vfrete
        End Get
        Set(value As Decimal)
            _vfrete = value
        End Set
    End Property

    Public Property perconsumidor As Decimal
        Get
            Return _perconsumidor
        End Get
        Set(value As Decimal)
            _perconsumidor = value
        End Set
    End Property

    Public Property valorconsumidor As Decimal
        Get
            Return _valorconsumidor
        End Get
        Set(value As Decimal)
            _valorconsumidor = value
        End Set
    End Property

    Public Property veiculo As Boolean
        Get
            Return _veiculo
        End Get
        Set(value As Boolean)
            _veiculo = value
        End Set
    End Property

    Public Property placa As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
        End Set
    End Property

    Public Property ano As String
        Get
            Return _ano
        End Get
        Set(value As String)
            _ano = value
        End Set
    End Property

    Public Property cor As String
        Get
            Return _cor
        End Get
        Set(value As String)
            _cor = value
        End Set
    End Property

    Public Property modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property despesas As Decimal
        Get
            Return _despesas
        End Get
        Set(value As Decimal)
            _despesas = value
        End Set
    End Property

    Public Property numeroori As String
        Get
            Return _numeroori
        End Get
        Set(value As String)
            _numeroori = value
        End Set
    End Property

    Public Property dataalte As Date
        Get
            Return _dataalte
        End Get
        Set(value As Date)
            _dataalte = value
        End Set
    End Property

    Public Property montapedido As Boolean
        Get
            Return _montapedido
        End Get
        Set(value As Boolean)
            _montapedido = value
        End Set
    End Property

    Public Property valodificms As Decimal
        Get
            Return _valodificms
        End Get
        Set(value As Decimal)
            _valodificms = value
        End Set
    End Property

    Public Property valoipi As Decimal
        Get
            Return _valoipi
        End Get
        Set(value As Decimal)
            _valoipi = value
        End Set
    End Property

    Public Property vimpsimples As Decimal
        Get
            Return _vimpsimples
        End Get
        Set(value As Decimal)
            _vimpsimples = value
        End Set
    End Property

    Public Property markup As Decimal
        Get
            Return _markup
        End Get
        Set(value As Decimal)
            _markup = value
        End Set
    End Property

    Public Property custoimpostos As Decimal
        Get
            Return _custoimpostos
        End Get
        Set(value As Decimal)
            _custoimpostos = value
        End Set
    End Property

    Public Property porsimples As Double
        Get
            Return _porsimples
        End Get
        Set(value As Double)
            _porsimples = value
        End Set
    End Property

    Public Property chassis As String
        Get
            Return _chassis
        End Get
        Set(value As String)
            _chassis = value
        End Set
    End Property

    Public Property renavan As String
        Get
            Return _renavan
        End Get
        Set(value As String)
            _renavan = value
        End Set
    End Property

    Public Property locregistro As String
        Get
            Return _locregistro
        End Get
        Set(value As String)
            _locregistro = value
        End Set
    End Property

    Public Property codcest As String
        Get
            Return _codcest
        End Get
        Set(value As String)
            _codcest = value
        End Set
    End Property

    Public Property quantidadeconversao As Double
        Get
            Return _quantidadeconversao
        End Get
        Set(value As Double)
            _quantidadeconversao = value
        End Set
    End Property

    Public Property produtoconversao As Boolean
        Get
            Return _produtoconversao
        End Get
        Set(value As Boolean)
            _produtoconversao = value
        End Set
    End Property

    Public Property produtotanque As Boolean
        Get
            Return _produtotanque
        End Get
        Set(value As Boolean)
            _produtotanque = value
        End Set
    End Property

    Public Property valortaxa As Decimal
        Get
            Return _valortaxa
        End Get
        Set(value As Decimal)
            _valortaxa = value
        End Set
    End Property

    Public Property anomodelo As String
        Get
            Return _anomodelo
        End Get
        Set(value As String)
            _anomodelo = value
        End Set
    End Property

    Public Property combustivel As String
        Get
            Return _combustivel
        End Get
        Set(value As String)
            _combustivel = value
        End Set
    End Property

    Public Property imposobrelucro As Double
        Get
            Return _imposobrelucro
        End Get
        Set(value As Double)
            _imposobrelucro = value
        End Set
    End Property

    Public Property custosobrelucro As Decimal
        Get
            Return _custosobrelucro
        End Get
        Set(value As Decimal)
            _custosobrelucro = value
        End Set
    End Property

    Public Property especietipo As String
        Get
            Return _especietipo
        End Get
        Set(value As String)
            _especietipo = value
        End Set
    End Property

    Public Property produtonaofiscal As Boolean
        Get
            Return _produtonaofiscal
        End Get
        Set(value As Boolean)
            _produtonaofiscal = value
        End Set
    End Property

    Public Property produtocereais As Boolean
        Get
            Return _produtocereais
        End Get
        Set(value As Boolean)
            _produtocereais = value
        End Set
    End Property

    Public Property produtotrigo As Boolean
        Get
            Return _produtotrigo
        End Get
        Set(value As Boolean)
            _produtotrigo = value
        End Set
    End Property

    Public Property datavencimentoprocuracao As Date
        Get
            Return _datavencimentoprocuracao
        End Get
        Set(value As Date)
            _datavencimentoprocuracao = value
        End Set
    End Property

    Public Property tortasoja As Boolean
        Get
            Return _tortasoja
        End Get
        Set(value As Boolean)
            _tortasoja = value
        End Set
    End Property

    Public Property oleosoja As Boolean
        Get
            Return _oleosoja
        End Get
        Set(value As Boolean)
            _oleosoja = value
        End Set
    End Property

    Public Property codmapa As String
        Get
            Return _codmapa
        End Get
        Set(value As String)
            _codmapa = value
        End Set
    End Property

    Public Property codunidade As String
        Get
            Return _codunidade
        End Get
        Set(value As String)
            _codunidade = value
        End Set
    End Property

    Public Property custozepel As Double
        Get
            Return _custozepel
        End Get
        Set(value As Double)
            _custozepel = value
        End Set
    End Property

    Public Property descanp As String
        Get
            Return _descanp
        End Get
        Set(value As String)
            _descanp = value
        End Set
    End Property

    Public Property unitributacao As String
        Get
            Return _unitributacao
        End Get
        Set(value As String)
            _unitributacao = value
        End Set
    End Property

    Public Property atualizado As Boolean
        Get
            Return _atualizado
        End Get
        Set(value As Boolean)
            _atualizado = value
        End Set
    End Property

    Public Property servicoatividade As Long
        Get
            Return _servicoatividade
        End Get
        Set(value As Long)
            _servicoatividade = value
        End Set
    End Property

    Public Property servicosubatividade As Long
        Get
            Return _servicosubatividade
        End Get
        Set(value As Long)
            _servicosubatividade = value
        End Set
    End Property

    Public Property quantidadefilial As Double
        Get
            Return _quantidadefilial
        End Get
        Set(value As Double)
            _quantidadefilial = value
        End Set
    End Property

    Public Property forabalanco As Boolean
        Get
            Return _forabalanco
        End Get
        Set(value As Boolean)
            _forabalanco = value
        End Set
    End Property

    Public Property nfecompra As String
        Get
            Return _nfecompra
        End Get
        Set(value As String)
            _nfecompra = value
        End Set
    End Property

    Public Property volumesiga As Double
        Get
            Return _volumesiga
        End Get
        Set(value As Double)
            _volumesiga = value
        End Set
    End Property

    Public Property forasiga As Boolean
        Get
            Return _forasiga
        End Get
        Set(value As Boolean)
            _forasiga = value
        End Set
    End Property

    Public Property vbcstret As Double
        Get
            Return _vbcstret
        End Get
        Set(value As Double)
            _vbcstret = value
        End Set
    End Property

    Public Property pst As Double
        Get
            Return _pst
        End Get
        Set(value As Double)
            _pst = value
        End Set
    End Property

    Public Property vicmsstret As Double
        Get
            Return _vicmsstret
        End Get
        Set(value As Double)
            _vicmsstret = value
        End Set
    End Property

    Public Property vbcfcpstret As Double
        Get
            Return _vbcfcpstret
        End Get
        Set(value As Double)
            _vbcfcpstret = value
        End Set
    End Property

    Public Property pfcpstret As Double
        Get
            Return _pfcpstret
        End Get
        Set(value As Double)
            _pfcpstret = value
        End Set
    End Property

    Public Property predbcefet As Double
        Get
            Return _predbcefet
        End Get
        Set(value As Double)
            _predbcefet = value
        End Set
    End Property

    Public Property vbcefet As Double
        Get
            Return _vbcefet
        End Get
        Set(value As Double)
            _vbcefet = value
        End Set
    End Property

    Public Property picmsefet As Double
        Get
            Return _picmsefet
        End Get
        Set(value As Double)
            _picmsefet = value
        End Set
    End Property

    Public Property vicmsefet As Double
        Get
            Return _vicmsefet
        End Get
        Set(value As Double)
            _vicmsefet = value
        End Set
    End Property

    Public Property origem As String
        Get
            Return _origem
        End Get
        Set(value As String)
            _origem = value
        End Set
    End Property

    Public Property letra As String
        Get
            Return _letra
        End Get
        Set(value As String)
            _letra = value
        End Set
    End Property

    Public Property codfornecedor As String
        Get
            Return _codfornecedor
        End Get
        Set(value As String)
            _codfornecedor = value
        End Set
    End Property

    Public Property idexportacao As Long
        Get
            Return _idexportacao
        End Get
        Set(value As Long)
            _idexportacao = value
        End Set
    End Property
End Class