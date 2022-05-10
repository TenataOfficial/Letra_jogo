﻿
Public Partial Class MainForm
	Public Sub New()
		iniciar
	End Sub
	
	Sub iniciar
		If iniciado= False Then
			Me.InitializeComponent()
			iniciado = true
		End If
	End Sub
	
	Dim iniciado As Boolean = false
	Dim p_select As Integer = 0
	Dim tentativas As Integer = 0
	Dim rnd As New Random
	Dim t As String = ""
	Dim l As label
	Dim l_n As Integer = 0
	Dim palavra As String = ""
	Dim palavra_colocada As new list(Of string)
	
	Sub MainFormKeyDown(sender As Object, e As KeyEventArgs)
		Select Case e.KeyCode
			Case Keys.Back
				Select p_select
				Case 0
					label26.Text = ""
				Case 1
					label27.Text = ""
				Case 2
					label28.Text = ""
				Case 3
					label29.Text = ""
				Case 4
					label30.Text = ""
				End Select
				If p_select > 0 Then
					p_select -= 1
				End If
			Case Keys.Left
				If p_select > 0 Then
					p_select -= 1
				Else
					p_select = 4
				End If
			Case Keys.Right
				If p_select < 4 Then
					p_select += 1
				Else
					p_select = 0
				End If
			Case Keys.Enter
				 t = label26.Text & label27.Text & label28.Text & label29.Text & label30.Text
				If t.Length = 5 Then
					label26.Text = ""
					label27.Text = ""
					label28.Text = ""
					label29.Text = ""
					label30.Text = ""

					For each x As String In lista1 
						If x.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i") = t.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ê","e").Replace("í","i") Then
							verificar_label
							exit For
						Else If x.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i") = "abner" then
							For each x2 As String In lista2 
								If x2.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i") = t.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ê","e").Replace("í","i") Then
								verificar_label
								exit For
								Else If x2.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i") ="pauto" then
								For each x3 As String In lista3
								If x3.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i") = t.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ê","e").Replace("í","i") Then
									verificar_label
								exit For
								Else If x3.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i") ="frito" Then
							MsgBox("Essa palavra não é aceita",vbOKOnly)
						End If
					Next
						End If
					Next
						End If
					Next
					
		
		If tentativas = 5 Then
			pf = palavra
						perdeu.show
						Me.hide
					End If
					
				End If
		End Select
	End Sub
	
	Public sub r_load
	Application.Restart
	End Sub
	Public Sub r_close
		Me.Close
	End Sub
	
	
	
	Sub verificar_label 
			if palavra_colocada.Contains(t.ToUpper) = true  then
		MsgBox("Essa palavra já foi usada",vbOKOnly)
	else
		If tentativas < 5 Then
			
		For i As Integer = 0 To 5
				Try
					Dim j As Integer = l_n+i
					DirectCast(Me.Controls.Find("Label" & j,True)(0) ,Label).Text = t.Chars(i-1)
					
					If palavra.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i").Contains(t.Chars(i-1).ToString.ToLower) = True Then
						
						If Not palavra.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i").Chars(i-1).ToString = t.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("ô","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ô","o").Replace("ê","e").Replace("í","i").Chars(i-1).ToString.ToLower Then
							DirectCast(Me.Controls.Find("Label" & j,True)(0) ,Label).BackColor = Color.yellow
						Else
							DirectCast(Me.Controls.Find("Label" & j,True)(0) ,Label).BackColor = Color.green
							DirectCast(Me.Controls.Find("Label" & j,True)(0) ,Label).Text = palavra.ToUpper.Chars(i-1)
						End If
						
					Else
						DirectCast(Me.Controls.Find("Label" & j,True)(0) ,Label).backcolor = Color.Black
						DirectCast(Me.Controls.Find("Label" & j,True)(0) ,Label).ForeColor = Color.White
					End If
				Catch ex As Exception
					
				End Try
					
		Next
		If palavra.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ê","e").Replace("í","i") = t.ToLower.Replace("à","a").Replace("â","a").Replace("ó","o").Replace("é","e").Replace("á","a").Replace("ã","a").Replace("õ","o").Replace("ê","e").Replace("í","i") Then
			timer2.Enabled = False
			Dim ponto As Decimal = (((5-tentativas)*((minutos * 100) -(segundos * 0.6 - (1000.00)))))
			If ponto < 0 Then
				ponto = 0 
			End If
			Dim m As String
			If minutos < 10 Then
				m = "0" & minutos
			Else
				m = minutos
			End If
			If segundos < 10 Then
				m = m & ":0" & segundos
			Else
				m = m & ":" & segundos
			End If
			minutos_enviar = (minutos * 60) + segundos
			pontos_enviar = ponto
			pf = "Você conseguiu" & vbNewLine & "seu tempo foi " & vbNewLine & m & vbNewLine & "Seus pontos = " & ponto 
			pontos.show()
			Me.close
		Else If tentativas <= 4 Then
			tentativas +=1
			l_n += 5
			p_select = 0
			palavra_colocada.Add(t.ToUpper)
			t = ""
		End If
		End if
		End If
	End Sub
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		
				label30.BackColor = Color.Gray
				label26.BackColor = Color.Gray
				label27.BackColor = Color.Gray
				label28.BackColor = Color.Gray
				label29.BackColor = Color.Gray
				
		Select p_select
			Case 0
				label26.BackColor = Color.DarkGray
			Case 1
				label27.BackColor = Color.DarkGray
			Case 2
				label28.BackColor = Color.DarkGray
			Case 3
				label29.BackColor = Color.DarkGray
			Case 4		
				label30.BackColor = Color.DarkGray
		End Select
		
	End Sub
	
	
	Sub MainFormKeyPress(sender As Object, e As KeyPressEventArgs)
		Dim c As Char = e.KeyChar
		
		If comecar = False Then
			comecar = True 
			timer2.Enabled =True
		Else
		End If 
		If Not char.IsLetter(c) Then
			e.Handled = False
		Else 
		
			Select p_select
				Case 0
					label26.Text = UCase(e.KeyChar)
				Case 1
					label27.Text = UCase(e.KeyChar)
				Case 2
					label28.Text = UCase(e.KeyChar)
				Case 3
					label29.Text = UCase(e.KeyChar)
				Case 4
					label30.Text = UCase(e.KeyChar)
			End Select
			If p_select < 4 then
				p_select += 1
			Else 
				p_select = 0
				End if
		End If
		
	End Sub
	
	#region "aqui os dados"
	Dim lista1() As String = {"fazia","fazes","fazer","fazem","fazei","favos","favor","favas","fauno","fauna","fatos","fator","fatiá","fatio","fatie","fatia","fatal","fases","farão","farás","fartá","farto","farte","farta","farsa","farra","farpa","faros","farol","faria","farei","fardo","farda","famas","faltá","falto","falte","falta","falso","falsa","falou","faliu","falis","falir","falia","falhá","falho","falhe","falha","fales","falem","falei","falda","falas","falar","falam","falai","faixa","faina","fados","fadas","facão","facho","faces","facas","Fábio","Filho","êmulo","êmula","ésimo","ésima","éreis","época","épico","épica","éguas","ébrio","ébano","ânsia","ânodo","ânimo","âmbar","âmago","ázimo","ávido","ávida","áureo","áurea","átrio","átono","átona","átomo","árido","árida","árias","áreas","árduo","árdua","árabe","ápice","álibi","álbum","álamo","águia","águas","ágios","ágeis","ágata","ágape","ácido","ácida","ácaro","ábaco","Érico","Érica","Épiro","Éfeso","Édipo","Ávila","Átila","estão","estás","estas","estar","estai","esses","essas","esqui","espiã","espiá","espio","espie","espia","escôo","escoá","escol","escoe","escoa","ervas","errou","erros","erres","errem","errei","erras","errar","erram","errai","erodo","erodi","erode","eroda","ermos","eriçá","eriço","eriça","erijo","erija","erigi","erige","erice","erguê","ergui","ergue","ergas","ergam","ereto","ereta","enviá","envio","envie","envia","entôo","então","entrá","entro","entre","entra","entoá","entoe","entoa","entes","enojá","enojo","enoje","enoja","enjôo","enjoá","enjoe","enjoa","enfiá","enfio","enfim","enfie","enfia","enchê","encho","enchi","enche","encha","emulá","emulo","emule","emula","emito","emiti","emite","emita","emaná","emano","emane","emana","elmos","elixo","elixi","elixe","elite","elevá","elevo","eleve","eleva","elejo","eleja","elegê","elegi","elege","ejetá","ejeto","ejete","ejeta","eixos","eiras","educá","educo","educa","editá","edito","edita","edema","ecoou","ecoes","ecoem","ecoei","ecoas","ecoar","ecoam","ecoai","dúzia","dúbio","dúbia","dólar","débil","dália","dutos","durou","duros","durmo","durma","dures","durem","durei","duras","durar","duram","durai","duque","duplo","dupla","dunga","dunas","dumas","dueto","duelá","duelo","duele","duela","ducha","dublá","dublo","duble","dubla","duais","drogá","drogo","droga","drená","dreno","drene","drena","drama","dragá","drago","draga","doído","doída","doías","doíam","douto","douta","dourá","douro","doure","doura","dotou","dotes","dotem","dotei","dotas","dotar","dotam","dotai","dosou","doses","dosem","dosei","dosas","dosar","dosam","dosai","dorso","dormi","dorme","dores","dopou","dopes","dopem","dopei","dopas","dopar","dopam","dopai","donos","donde","donas","domou","domes","domem","domei","domas","domar","domam","domai","doido","doida","dogma","doerá","doera","doemo","doeis","docas","dobrá","dobro","dobre","dobra","doava","doará","doara","doamo","doais","doado","doada","dizia","dizes","dizer","dizem","dizei","divas","ditou","ditos","dites","ditem","ditei","ditas","ditar","ditam","ditai","distá","disto","diste","dista","disso","disse","dispô","discá","disco","disca","dirão","dirás","diria","direi","dique","diodo","diluí","diluo","dilui","dilua","digná","digno","digne","digna","digas","digam","dieta","dicas","diabo","devia","deveu","deves","dever","devem","devei","devas","devam","deusa","detém","deter","desço","desça","deste","desta","desse","dessa","despi","despe","desde","descê","desci","desce","dermo","deres","derem","deras","deram","depõe","depôs","depus","depor","dente","denso","densa","demão","demos","delta","deles","delas","deixá","deixo","deixe","deixa","deitá","deito","deite","deita","dedão","deduz","dedos","dedal","decaí","decai","davas","davam","datou","dates","datem","datei","datas","datar","datam","datai","darão","darás","daria","dares","darem","darei","dardo","daqui","dançá","danço","dança","dante","danou","danos","danes","danem","danei","dando","dance","danas","danar","danam","danai","damos","damas","dados","dadas","cútis","cúria","côdea","cópia","cólon","cívil","círio","cílio","césio","célia","cápua","cuíca","custá","custo","custe","custa","cuspo","cuspi","cuspa","curvá","curvo","curve","curva","curto","curti","curte","curta","cursá","curso","curse","cursa","curou","cures","curem","curei","curas","curar","curam","curai","cupom","cupim","cunhá","cunho","cunhe","cunha","cumes","culto","culta","culpá","culpo","culpe","culpa","cujus","cujos","cujas","cuidá","cuido","cuide","cuida","cuias","cueca","cucos","cucas","cubro","cubra","cubos","cubas","crêem","cruzá","cruzo","cruze","cruza","cruel","cruas","cromá","cromo","crome","croma","crivá","crivo","crive","criva","crise","criou","crina","crime","cries","criem","criei","crido","crias","criar","criam","criai","crerá","crera","cremá","cremo","creme","crema","creio","creia","credo","crede","cravá","cravo","crave","crava","coíbo","coíbe","coíba","coçou","coças","coçar","coçam","coçai","cozia","cozeu","cozes","cozer","cozem","cozei","cozas","cozam","coxos","coxim","coxas","covas","couve","couro","coube","cotou","cotes","cotem","cotei","cotas","cotar","cotam","cotai","costa","cospe","cosmo","cosia","coseu","coses","coser","cosem","cosei","cosas","cosam","corôo","corôa","corça","corvo","cortá","corto","corte","corta","corrê","corro","corri","corre","corra","corpo","coroá","corou","coros","coroe","coroa","corno","corja","cores","corem","corei","corda","coras","corar","coram","coral","corai","copos","copiá","copio","copie","copia","copas","contê","contá","conto","conte","conta","congá","cones","conde","comum","compô","comia","comeu","comes","comer","comem","comei","comas","comam","colou","colhê","colho","colhi","colhe","colha","coles","colem","colei","colas","colar","colam","colai","coito","coisa","coifa","coice","coibi","cofre","coevo","coeva","coeso","coesa","coemo","coeis","cocos","cocho","coces","cocem","cocei","cocal","cobrá","cobro","cobri","cobre","cobra","coaxá","coaxo","coaxe","coaxa","coava","coará","coara","coamo","coajo","coaja","coais","coagi","coage","coado","coada","clube","cloro","clone","clips","clima","clero","clava","claro","clara","clamá","clamo","clame","clama","ciúme","civis","civil","citou","cites","citem","citei","citas","citar","citam","citai","cisão","cisne","cismá","cismo","cisme","cisma","ciscá","cisco","cisca","circo","cipós","cioso","ciosa","cinza","cinto","cinta","cinjo","cinja","cingi","cinge","cindo","cindi","cinde","cinda","cinco","cifrá","cifro","cifre","cifra","cidra","ciclo","chuva","chutá","chuto","chute","chuta","chupá","chupo","chupe","chupa","choça","chovê","chovo","chovi","chove","chova","chorá","choro","chore","chora","chocá","choco","choca","chiou","chies","chiem","chiei","chias","chiar","chiam","chiai","cheio","cheia","chegá","chego","chega","chefe","chefa","checá","checo","checa","chave","chato","chata","chapa","chamá","chamo","chame","chama","chalé","chale","chagá","chago","chaga","cetro","cetim","cesto","cesta","cessá","cesso","cesse","cessa","cervo","certo","certa","cerrá","cerro","cerre","cerra","cerol","cerni","cerne","cerda","cercá","cerco","cerca","ceras","cento","censo","cenas","celta","celas","ceifá","ceifo","ceife","ceifa","ceies","ceiem","ceias","ceiam","cegue","cegou","cegos","cegas","cegar","cegam","cegai","ceemo","ceeis","cedro","cedia","cedeu","cedes","ceder","cedem","cedei","cedas","cedam","ceava","ceara","ceamo","ceais","ceado","caíra","caímo","caído","caída","caías","caíam","caçôo","cação","caçoá","caçou","caçoe","caçoa","caças","caçar","caçam","caçai","cavou","caviá","cavio","cavie","cavia","caves","cavem","cavei","cavas","cavar","cavam","cavai","cauto","cauta","causá","causo","cause","causa","caule","cauda","catre","catou","cates","catem","catei","catas","catar","catam","catai","casto","casta","cassá","casso","casse","cassa","caspa","casou","casos","cases","casem","casei","casco","casca","casas","casar","casam","casal","casai","carão","carta","carro","carpi","carpe","carpa","caros","carne","carmo","cargo","carga","cardo","caras","capuz","caput","captá","capto","capte","capta","capou","capim","capes","capem","capei","capaz","capas","capar","capam","capai","cantá","canto","cante","canta","cansá","canso","canse","cansa","canos","canoa","canja","canga","canaã","canas","canal","campo","camas","calçá","calço","calça","calvo","calva","calou","calos","calor","calmo","calma","calhá","calho","calhe","calha","cales","calem","calei","caldo","calda","calcá","calco","calce","calca","calas","calar","calam","calai","caixa","cairá","caiou","caies","caiem","caiei","caido","caibo","caiba","caias","caiar","caiam","caiai","cague","cagou","cagas","cagar","cagam","cagai","cafés","cacto","cacos","cacho","caces","cacem","cacei","cacas","cabra","cabos","cabia","cabes","caber","cabem","cabei","búzio","bônus","bôers","bóies","bóiem","bóias","bóiam","bílis","bário","buxos","busto","buscá","busco","busca","burro","burra","burlá","burlo","burle","burla","burgo","bundá","bundo","bunde","bunda","bumbo","buliu","bulis","bulir","bulia","bules","bulbo","bulas","bulam","bujão","bufão","bufou","bufes","bufem","bufei","bufas","bufar","bufam","bufai","bueno","bucho","bucha","bucal","bruxo","bruxa","bruto","bruta","bruma","brotá","broto","brote","brota","bromo","brocá","broco","broca","broas","brito","brita","brisa","brios","brins","brigá","brigo","briga","brida","brevê","breve","bretã","brejo","brecá","breco","breca","braço","braça","bravo","brava","brasa","bramá","bramo","brami","brame","brama","bradá","brado","brade","brada","brabo","braba","boxeá","botão","botou","botes","botem","botei","botas","botar","botam","botai","bosta","bossa","borrá","borro","borre","borra","bordá","bordo","borde","borda","bonés","bonde","bomba","bolão","bolso","bolsa","bolou","bolos","bolha","boles","bolem","bolei","boldo","bolas","bolar","bolam","bolai","boiou","boina","boiei","boiar","boiai","bodes","bodas","bocha","bocas","bocal","bobos","bobeá","bobas","boato","boate","blusa","bloco","blefá","blefo","blefe","blefa","bisão","bispo","birra","bique","bingo","bigas","biela","bicou","bicos","bicho","bicha","bicas","bicar","bicam","bicai","besta","berço","berrá","berro","berre","berra","beque","benzê","benzo","benzi","benze","benza","benta","bemol","belos","belga","belas","beiço","beirá","beiro","beire","beira","beijá","beijo","beije","beija","becos","becas","bebês","bebia","bebeu","bebes","beber","bebem","bebei","bebas","bebam","beato","beata","baías","baços","bazar","bauru","batom","batia","bateu","bates","bater","batem","batel","batei","batas","batam","bastá","basto","baste","basta","baseá","bases","barão","barrá","barro","barre","barra","bares","bardo","barco","barca","barba","baque","banjo","baniu","banis","banir","bania","banhá","banho","banhe","banha","banes","banem","bando","banda","bancá","banco","banca","banal","bambu","bambo","bamba","balão","balsa","baliu","balis","balir","balia","baleá","bales","balem","balde","balas","balam","baião","baixá","baixo","baixe","baixa","baita","bailá","bailo","baile","baila","baias","bagos","bagas","bafos","bacia","babão","babás","babou","babes","babem","babei","babas","babar","babam","babai","aéreo","aérea","ações","açude","azulá","azulo","azule","azula","azuis","azoto","azias","azedá","azedo","azede","azeda","azará","azaro","azare","azara","axila","axial","avéns","avião","avivá","avivo","avive","aviva","avisá","aviso","avise","avisa","avirá","aviou","avimo","avies","avier","aviem","aviei","avias","aviar","aviam","aviai","avelã","aveio","aveia","avaro","avara","avais","autuá","autuo","autue","autua","autos","autor","auras","aulas","audaz","aténs","atéia","aturá","aturo","ature","atura","atuou","atuns","atues","atuem","atuei","atuas","atuar","atuam","atual","atuai","atrás","atriz","atraí","atrai","atolá","atolo","atole","atola","atlas","atiçá","atiço","atiça","ativá","ativo","ative","ativa","atirá","atiro","atire","atira","atiná","atino","atine","atina","atido","atice","ateve","ateus","aterá","ateou","atemo","ateis","ateio","ateie","ateia","ateei","atear","ateai","atava","atará","atara","atamo","atais","atado","atada","atacá","ataco","ataca","astro","assôo","assoá","assou","assoe","assoa","assis","assim","asseá","asses","assem","assei","assaz","assas","assar","assam","assai","aspas","asnos","asilá","asilo","asile","asila","artes","arroz","arriá","arrio","arrie","arria","arreá","arque","arpôo","arpão","arpoá","arpoe","arpoa","aroma","armou","armes","armem","armei","armas","armar","armam","armai","argüi","argúi","arguí","arguo","argua","arfou","arfes","arfem","arfei","arfas","arfar","arfam","arfai","arena","aremo","arejá","arejo","areje","areja","areis","areia","areal","ardor","ardis","ardil","ardia","ardeu","ardes","arder","ardem","ardei","ardas","ardam","arcou","arcos","arcas","arcar","arcam","arcai","araçá","arava","arará","arara","aramo","arame","arais","arado","arada","aquém","apóio","apóie","apóia","apurá","apuro","apure","apura","aptos","aptas","apolo","apoiá","apoio","apitá","apito","apite","apita","apeou","apená","apeno","apene","apena","apelá","apelo","apele","apela","apeio","apeie","apeia","apegá","apego","apega","apeei","apear","apeai","apará","aparo","apare","apara","apagá","apago","apaga","aorta","aonde","anões","anéis","anzol","anuís","anuía","anulá","anulo","anule","anula","anuiu","anuis","anuir","anuem","anuas","anuam","anual","antão","antro","antes","antas","ansiá","anotá","anoto","anote","anota","anjos","animá","animo","anime","anima","angra","anglo","anexá","anexo","anexe","anexa","anelá","anelo","anele","anela","andou","andor","andes","andem","andei","andas","andar","andam","andai","anciã","ancas","anais","amplo","ampla","amolá","amolo","amole","amola","amimá","amimo","amime","amima","amigá","amigo","amiga","amido","ameça","ameno","amena","amemo","ameis","ameia","ameba","ambos","ambas","amava","amará","amaro","amara","amamo","amais","amado","amada","alçou","alças","alçar","alçam","alçai","alvos","alvor","alves","alvas","aluno","aluna","alugá","alugo","aluga","aludo","aludi","alude","aluda","altos","alteá","altas","altar","aloés","alojá","alojo","aloje","aloja","alocá","aloco","aloca","almas","aliás","alisá","aliso","alise","alisa","aliou","alijá","alijo","alije","alija","alies","aliem","aliei","alias","aliar","aliam","aliai","alhos","alheá","algum","algoz","algas","alemã","alegá","alego","alega","aldeã","alces","alcem","alcei","alagá","alago","alaga","alado","alada","ajudá","ajudo","ajude","ajuda","ajamo","ajais","ainda","aguçá","aguço","aguça","aguou","agues","aguem","aguei","agudo","aguda","aguce","aguas","aguar","aguam","aguai","agora","agitá","agito","agite","agita","agirá","agira","agimo","agido","agias","agiam","aftas","afros","aforá","aforo","afore","afora","afogá","afogo","afoga","afofá","afofo","afofe","afofa","afobá","afobo","afobe","afoba","afluí","afluo","aflui","aflua","afixá","afixo","afixe","afixa","afiro","afira","afiou","afiná","afins","afino","afine","afina","afies","afiem","afiei","afias","afiar","afiam","afiai","afetá","afeto","afete","afeta","aferi","afere","afegã","afaná","afano","afane","afana","afagá","afago","afaga","advém","advir","advim","adulá","adulo","adule","adula","adubá","adubo","adube","aduba","adoçá","adoço","adoça","adotá","adoto","adote","adota","adorá","adoro","adore","adora","adoce","aditá","adito","adite","adita","adirá","adiro","adira","adiou","adimo","adies","adiem","adiei","adido","adida","adias","adiar","adiam","adiai","adeus","aderi","adere","adega","adaga","acusá","acuso","acuse","acusa","acuou","acues","acuem","acuei","acudo","acudi","acuda","acuas","acuar","acuam","acuai","acolá","acode","acima","achou","aches","achem","achei","achas","achar","acham","achai","aceto","aceso","acesa","acená","aceno","acene","acena","acatá","acato","acate","acata","acaso","acabá","acabo","acabe","acaba","abusá","abuso","abuse","abusa","abstê","abriu","abris","abrir","abril","abria","abreu","abres","abrem","abras","abram","abono","aboli","abole","abluí","abluo","ablui","ablua","abeto","abatê","abato","abati","abate","abata","abaná","abano","abane","abana","abalá","abalo","abale","abala","abafá","abafo","abafe","abafa","abade","Ester","Esopo","Emaús","Elixa","Elisa","Elias","Egito","Edite","Edgar","Délhi","Dácia","Dubai","Diana","Dhaka","Denis","Delhi","David","Dario","Darci","Dakar","Dafne","Dacca","César","Cátia","Couto","China","Chile","Chico","Chica","Ceará","Carla","Cairo","Busan","Bruno","Braga","Borba","Bielo","Berta","Berna","Bento","Belém","Bangu","Bahia","Bagdá","Babel","Aécio","Artur","Argos","Argel","André","Amora","Amapá","Alpes","Aline","Algol","Alceu","Alair","Aires","Acker","Accra","Acaia","Abner"}
	Dim lista2() As String = {"zíper","zurrá","zurro","zurre","zurra","zuniu","zunis","zunir","zunia","zunes","zunem","zunas","zunam","zumbo","zumbi","zumbe","zumba","zonzo","zonza","zonas","zombá","zombo","zombe","zomba","zinco","zerou","zeros","zeres","zerem","zerei","zeras","zerar","zeram","zerai","zelou","zeles","zelem","zelei","zelas","zelar","zelam","zelai","zebra","zarpá","zarpo","zarpe","zarpa","zanzá","zanzo","zanze","zanza","zangá","zango","zanga","zagas","Zaria","xérox","xucro","xucra","xisto","xingá","xingo","xinga","xiita","xerox","xeque","xelim","xarás","xales","vôlei","vírus","víeis","vídeo","vício","vênia","vária","vácuo","vulva","vulto","vulgo","vozes","vovôs","vovós","votou","votos","votes","votem","votei","votas","votar","votam","votai","vosso","vossa","voraz","volvê","volvo","volvi","volve","volva","voltá","volto","volte","volta","vogal","voemo","voeis","vodca","vocês","voava","voará","voara","voamo","voais","voado","viúvo","viúva","viões","vivos","vivia","viveu","vives","viver","vivem","vivei","vivaz","vivas","vivam","viuvá","viuvo","viuve","viuva","vital","visão","visto","viste","visse","visou","vises","visem","visei","visas","visar","visam","visai","virão","virás","virou","virmo","viris","viril","viria","vires","virem","virei","viras","virar","viram","virai","violá","violo","viole","viola","vinte","vinho","vinha","vingá","vingo","vinga","vindo","vinde","vinda","vincá","vinco","vinca","vimos","vilãs","vilão","vilas","vigor","vigiá","vigio","vigie","vigia","vigas","vieza","viera","viela","vidrá","vidro","vidre","vidra","vidas","viciá","vicio","vicie","vicia","vibrá","vibro","vibre","vibra","viana","viajá","viajo","viaje","viaja","vezes","vexou","vexes","vexem","vexei","vexas","vexar","vexam","vexai","vetou","vetor","vetes","vetem","vetei","vetas","vetar","vetam","vetai","vesti","veste","vespa","vesgo","vesga","verão","verás","vertê","verto","verti","verte","verta","versá","verso","verse","versa","verme","veria","verga","veres","verem","verei","verde","verba","venço","vença","ventá","vento","vente","venta","venho","venha","vendê","vendá","vendo","vendi","vende","venda","vencê","venci","vence","venal","vemos","veloz","velou","velho","velha","veles","velem","velei","velas","velar","velam","velai","vejas","vejam","vejai","veias","vedou","vedes","vedem","vedei","vedas","vedar","vedam","vedai","veado","vazão","vazou","vazio","vazia","vazes","vazem","vazei","vazas","vazar","vazam","vazai","vasto","vasta","vasos","varão","varrê","varro","varri","varre","varra","varou","variá","vario","varie","varia","vares","varem","varei","varas","varar","varam","varai","vapor","vamos","valsa","valos","valor","valia","valho","valha","valeu","vales","valer","valem","valei","valas","vaiou","vaies","vaiem","vaiei","vaias","vaiar","vaiam","vaiai","vagão","vague","vagou","vagos","vagiu","vagis","vagir","vagia","vagem","vagas","vagar","vagam","vagai","vadiá","vadio","vadie","vadia","vadeá","vades","vacas","Vênus","Vista","Viena","Verbo","Vegas","VARIG","usura","usual","usina","usemo","useis","usava","usará","usara","usamo","usais","usado","usada","uréia","urubu","ursos","ursas","urrou","urros","urres","urrem","urrei","urras","urrar","urram","urrai","urnas","urjas","urjam","uriná","urino","urine","urina","urgiu","urgis","urgir","urgia","urges","urgem","urdiu","urdis","urdir","urdia","urdes","urdem","urdas","urdam","urano","unção","untou","untes","untem","untei","untas","untar","untam","untai","unirá","unira","unimo","unido","unida","unias","uniam","unhas","ungiu","ungis","ungir","ungia","unges","ungem","unemo","unais","ululá","ululo","ulule","ulula","ultra","uivou","uivos","uives","uivem","uivei","uivas","uivar","uivam","uivai","ufaná","ufano","ufane","ufana","União","túnel","tório","tórax","tíbio","tíbia","tênue","tênis","tédio","táxis","tábua","tutor","tusso","tussa","turvá","turvo","turve","turva","turnê","turno","turma","turco","turca","turbá","turbo","turbe","turba","tupis","tumor","tumba","tufão","tubos","tróia","truta","trufa","truco","troçá","troço","troça","trova","trotá","troto","trote","trota","tropa","trono","trocá","troco","troce","troca","tripa","trios","trino","trina","trigo","tricô","tribo","treze","trevo","treva","treta","trepá","trepo","trepe","trepa","trenó","trens","trena","tremê","tremo","tremi","treme","trema","treco","traís","traía","traçá","traço","traça","trazê","traze","travá","travo","trave","trava","tratá","trato","trate","trata","trará","trapo","trama","trajá","trajo","traje","traja","traiu","trais","trair","traio","traia","tragá","trago","traga","traem","trace","touro","touca","totem","total","tostá","tosto","toste","tosta","tossi","tosse","tosou","toses","tosem","tosei","tosco","tosca","tosas","tosar","tosam","tosai","torço","torça","torto","torta","torrá","torro","torre","torra","torpe","toros","torná","torno","torne","torna","torcê","torci","torce","toras","toque","topou","topos","topes","topem","topei","topas","topar","topam","topai","tonto","tonta","tonel","tomou","tomes","tomem","tomei","tombá","tombo","tombe","tomba","tomas","tomar","tomam","tomai","tolos","tolhê","tolho","tolhi","tolhe","tolha","toldo","tolas","togas","todos","todas","tocou","tocha","tocas","tocar","tocam","tocai","toada","tição","tiver","titãs","titio","titia","tirou","tiros","tires","tirem","tirei","tiras","tirar","tiram","tirai","tipos","tinto","tinta","tinjo","tinja","tiniu","tinis","tinir","tinia","tinha","tingi","tinge","tines","tinem","tinas","tinam","timão","times","tigre","tietê","tidos","tidas","tiara","teças","teçam","texto","tetos","tetas","tesão","testá","testo","teste","testa","tesos","teses","tesas","terço","terça","terão","terás","terno","terna","termo","teria","teres","terem","terei","tentá","tento","tente","tenta","tenso","tensa","tenro","tenra","tenor","tenho","tenha","tendê","tendo","tendi","tende","tenda","tenaz","tempo","temos","temor","temia","temeu","temes","temer","temem","temei","temas","temam","telão","telha","teles","telas","teimá","teimo","teime","teima","teias","teclá","teclo","tecle","tecla","tecia","teceu","teces","tecer","tecem","tecei","taças","taxou","taxes","taxem","taxei","taxas","taxar","taxam","taxai","tatuá","tatus","tatuo","tatue","tatua","tateá","tarja","tardá","tardo","tarde","tarda","taras","taque","tapão","tapou","tapeá","tapes","tapem","tapei","tapas","tapar","tapam","tapai","tantã","tanto","tanta","tanjo","tanja","tangê","tango","tangi","tange","tanga","tampá","tampo","tampe","talão","talos","talhá","talho","talhe","talha","talco","talas","taipa","tacou","tacos","tachá","tacho","tache","tacha","tacas","tacar","tacam","tacai","tabas","Turim","Tomás","Texas","Terra","Teerã","Tampa","sótão","sósia","sódio","sócio","sócia","sítio","sírio","símio","sílex","sêmen","sério","série","séria","sépia","sábio","sábia","suíço","suíno","suína","sutiã","sutis","sutil","sustê","sustá","susto","susti","suste","susta","surto","surte","surta","surrá","surro","surre","surra","surjo","surja","surgi","surge","surdo","surda","supõe","supôs","supus","supro","supri","supre","supra","supor","super","sunga","sumiu","sumis","sumir","sumia","sumas","sumam","sulfa","sulcá","sulco","sulca","sujou","sujos","sujes","sujem","sujei","sujas","sujar","sujam","sujai","sugue","sugou","sugas","sugar","sugam","sugai","suemo","sueis","sueco","sueca","sucos","subiu","subis","subir","subia","subas","subam","suave","suava","suará","suara","suamo","suais","suado","suada","sovou","soves","sovem","sovei","sovas","sovar","sovam","sovai","sousa","soube","sorvê","sorvo","sorvi","sorve","sorva","sorti","sorte","sorta","sorri","soros","soque","sopés","soprá","sopro","sopre","sopra","sopas","sonso","sonsa","sonos","sonhá","sonho","sonhe","sonha","sondá","sondo","sonde","sonda","somou","somos","somes","somem","somei","somas","somar","somam","somai","soltá","solto","solte","solta","solou","solos","soles","solem","solei","soldá","soldo","solde","solda","solas","solar","solam","solai","sogro","sogra","sofás","sofrê","sofro","sofri","sofre","sofra","soemo","soeis","socou","socos","socas","socar","socam","socai","sobrá","sobro","sobre","sobra","sobes","sobem","soava","soará","soara","soamo","soais","soado","situá","situo","situe","situa","sitos","sitiá","sitio","sitie","sitia","sitas","sismá","sismo","sisme","sisma","sirzo","sirza","sirvo","sirva","siris","sinto","sinta","sinos","sinas","sinal","simão","silvá","silvo","silve","silos","signo","sigma","sigla","sigas","sigam","sifão","seção","sexto","sexta","sexos","setor","setas","sesta","serão","serás","serzi","serze","servo","servi","serve","serva","serrá","serro","serre","serra","seriá","serio","serie","seria","seres","serem","serei","seque","senão","sentá","sento","senti","sente","senta","senso","senos","senha","sendo","senda","semeá","selva","selou","selos","selim","seles","selem","selei","selas","selar","selam","selai","sejas","sejam","seixo","seiva","seita","seios","segui","segue","seduz","sediá","sedio","sedie","sedia","sedes","sedas","secou","secos","secas","secar","secam","secai","sebos","sebes","seara","saúva","saúdo","saúde","saúda","saíra","saímo","saído","saída","saías","saíam","saxão","sauna","saudá","sarça","sarou","sarna","sares","sarem","sarei","sarda","saras","sarar","saram","sarai","saque","sapos","sanou","sanha","saneá","sanes","sanem","sanei","sanas","sanar","sanam","sanai","sambá","sambo","sambe","samba","salão","salvá","salvo","salve","salva","saltá","salte","salta","salsa","salmo","salgá","salgo","salga","sales","saldá","saldo","salde","salda","salas","sairá","saido","saiba","saias","saiam","sagrá","sagro","sagre","sagra","sagaz","sagas","safra","safou","safes","safem","safei","safas","safar","safam","safai","sadio","sadia","sacro","sacra","sacou","sacos","saciá","sacis","sacio","sacie","sacia","sacas","sacar","sacam","sacai","sabão","sabre","sabor","sabia","sabes","saber","sabem","sabei","Sônia","Síria","Suíça","Sudão","Souza","Silva","Santo","Santa","Salto","Saara","róseo","rósea","rócio","ríeis","régua","régio","régia","rédea","rádio","ruína","ruído","russo","russa","rusga","rural","rumou","rumos","rumor","rumes","rumem","rumei","rumas","rumar","rumam","rumai","rujas","rujam","ruivo","ruiva","ruirá","ruira","ruins","ruimo","ruido","ruias","ruiam","rugue","rugou","rugiu","rugis","rugir","rugia","ruges","rugem","rugas","rugar","rugam","rugai","rufou","rufes","rufem","rufei","rufas","rufar","rufam","rufai","ruela","rudes","rubro","rubra","rublo","rubis","roído","roída","roías","roíam","roçou","roças","roçar","roçam","roçai","roxos","roxas","roupa","rouco","rouca","roubá","roubo","roube","rouba","rotos","roteá","rotas","rosto","rosná","rosno","rosne","rosna","rosca","rosas","roque","rondá","rondo","ronde","ronda","roncá","ronco","ronca","romãs","rompê","rompo","rompi","rompe","rompa","rombo","rolou","rolos","rolha","roles","rolem","rolei","rolas","rolar","rolam","rolai","rojão","rogue","rogou","rogos","rogas","rogar","rogam","rogai","roerá","roera","roemo","roeis","rodou","rodos","rodeá","rodes","rodem","rodei","rodas","rodar","rodam","rodai","rocha","roces","rocem","rocei","rocas","robôs","roamo","roais","rixas","rival","ritos","ritmo","riste","risse","risos","riscá","risco","risca","rirão","rirás","rirmo","riria","rires","rirem","rirei","riras","riram","ripas","rindo","rimou","rimos","rimes","rimem","rimei","rimas","rimar","rimam","rimai","rijos","rijas","rigor","rifou","rifle","rifes","rifem","rifei","rifas","rifar","rifam","rifai","rides","ricos","ricas","ribas","riamo","riais","reúno","reúne","reúna","rezou","rezes","rezem","rezei","rezas","rezar","rezam","rezai","revês","revés","reviu","revir","revia","rever","reuni","retém","retos","reter","retas","restá","resto","reste","resta","resma","reses","repõe","repôs","repus","repor","rente","rendê","rendo","rendi","rende","renda","renas","renal","remôo","remói","remoí","remoê","remou","remos","remoe","remoa","remiu","remis","remir","remia","remes","remem","remei","remas","remar","remam","remai","relês","relva","relia","releu","reles","reler","rejas","rejam","reiná","reino","reine","reina","regue","regrá","regro","regre","regra","regou","regia","regeu","reges","reger","regem","regei","regas","regar","regam","regai","refém","refiz","refez","refaz","reduz","redor","redil","redes","recém","recuá","recuo","recue","recua","receá","recaí","recai","rebôo","reboá","reboe","reboa","reavê","reatá","reato","reate","reata","reajo","reaja","reais","reagi","reage","ração","raças","razão","ratos","rateá","ratas","rasto","raspá","raspo","raspe","raspa","rasos","rasgá","rasgo","rasga","rasas","raros","rareá","raras","rapés","raptá","rapto","rapte","rapta","rapou","rapes","rapem","rapei","rapaz","rapas","rapar","rapam","rapai","ranço","ranjo","ranja","rangê","rangi","range","rampa","ralou","ralos","ralhá","ralho","ralhe","ralha","rales","ralem","ralei","ralas","ralar","ralam","ralai","rajou","rajes","rajem","rajei","rajas","rajar","rajam","rajai","raiva","raiou","raios","raies","raiem","raiei","raias","raiar","raiam","raiai","radiá","radio","radie","radia","radar","rachá","racho","rache","racha","rabos","Rouen","Romeu","Riade","Ramos","Rabat","púbis","pônei","pólos","pódio","pênis","pêlos","pátio","páreo","puxão","puxou","puxes","puxem","puxei","puxas","puxar","puxam","puxai","putos","putas","puser","puros","purgá","purgo","purga","puras","puniu","punis","punir","punia","punho","punha","punes","punem","punas","punam","pumas","pulsá","pulso","pulse","pulsa","pulou","pulos","pulga","pules","pulem","pulei","pulas","pular","pulam","pulai","pudor","pudim","puder","prumo","provê","prová","provo","provi","prove","prova","prosa","propô","prole","proas","privá","privo","prive","priva","primá","primo","prime","prima","preço","prezá","prezo","preze","preza","prevê","previ","preto","preta","preso","presa","prepô","premo","premi","preme","prema","prelo","pregá","prego","prega","prece","praça","prazo","praxe","prato","prata","praia","prado","poção","poços","poças","povôo","povão","povoá","povos","povoe","povoa","pousá","pouso","pouse","pousa","poupá","poupo","poupe","poupa","pouco","pouca","potro","potes","postá","posto","poste","posta","posso","posse","possa","pospô","posou","poses","posem","posei","posas","posar","posam","posai","porém","porão","porás","portá","porte","porta","porre","porra","poros","poria","pores","porem","porei","porco","porca","ponto","ponte","ponta","ponho","ponha","pondo","ponde","poncã","pompa","pomos","pombo","pomba","pomar","polvo","polpa","poliu","polis","polir","polia","polca","polar","poeta","poema","podou","podia","podes","poder","podem","podei","podas","podar","podam","podai","pobre","pneus","pluma","plugá","plugo","pluga","plotá","ploto","plote","plota","pleno","plena","plebe","platô","planá","plano","plane","plana","placa","pizza","pixel","pivôs","pista","pisou","pises","pisem","pisei","piscá","pisco","pisca","pisas","pisar","pisam","pisai","pirão","pires","pique","pipas","piorá","pioro","piore","piora","pinçá","pinço","pinça","pintá","pinto","pinte","pinta","pinos","pinho","pinha","pingá","pingo","pinga","pince","pilão","pilhá","pilho","pilhe","pilha","pilar","pifou","pifes","pifem","pifei","pifas","pifar","pifam","pifai","piemo","pieis","picão","picou","picos","pichá","picho","piche","picha","picas","picar","picam","picai","piava","piará","piara","piano","piamo","piais","piado","piada","peões","peças","peçam","petiz","peste","pesou","pesos","peses","pesem","pesei","pescá","pesco","pesca","pesas","pesar","pesam","pesai","perus","perua","perto","persa","perna","perdê","perdi","perde","perda","perco","perca","peras","peque","pente","pensá","penso","pense","pensa","penou","penes","penem","penei","pendê","pendo","pendi","pende","penda","penca","penas","penar","penam","penal","penai","pelou","pelos","peles","pelem","pelei","pelas","pelar","pelam","pelai","peixe","peitá","peito","peite","peita","peidá","peido","peide","peida","pegue","pegou","pegas","pegar","pegam","pegai","pedra","pediu","pedis","pedir","pedia","pedes","pedem","pedal","pecou","pecas","pecar","pecam","pecai","pazes","pavão","pavor","pavio","pautá","pauto"}
	Dim lista3() As String = {"paute","pauta","pausa","patuá","patos","patim","patas","pastá","pasto","paste","pasta","passá","passo","passe","passa","pasmá","pasmo","pasme","pasma","parvo","parto","parti","parte","parta","parou","pariu","parir","paria","pareá","pares","parem","parei","pardo","parda","parco","parca","paras","parar","param","parai","papão","papou","papos","papes","papem","papel","papei","papas","papar","papam","papai","pança","panos","panda","panca","pampa","palmo","palma","palha","palco","pajeá","pairá","pairo","paire","paira","pagãs","pagão","pague","pagou","pagos","pagem","pagas","pagar","pagam","pagai","padre","pacto","Praga","Porto","Piauí","Pedro","Peano","Paulo","Paula","Paris","oásis","oxidá","oxido","oxide","oxida","oxalá","ovino","ovais","ouças","ouçam","ouviu","ouvis","ouvir","ouvia","ouves","ouvem","outro","outra","ousou","ouses","ousem","ousei","ousas","ousar","ousam","ousai","ouros","ostra","ossos","orçou","orças","orçar","orçam","orçai","ornou","ornes","ornem","ornei","ornas","ornar","ornam","ornai","orlou","orles","orlem","orlei","orlas","orlar","orlam","orlai","orgia","oremo","oreis","ordem","orces","orcem","orcei","orcas","orava","orará","orara","oramo","orais","orado","opões","opõem","opção","optou","optes","optem","optei","optas","optar","optam","optai","oporá","opomo","opiná","opino","opine","opina","operá","opero","opere","opera","opala","opaco","opaca","onças","ontem","onerá","onero","onere","onera","ondeá","ondas","omito","omiti","omite","omita","omega","ombro","oliva","olhou","olhos","olhes","olhem","olhei","olhas","olhar","olham","olhai","oitão","ogiva","oeste","odiou","odiei","odiar","odiai","odeio","odeie","odeia","ocupá","ocupo","ocupe","ocupa","ocaso","obviá","obvio","obvie","obvia","obtém","obter","obstá","obsto","obste","obsta","obras","obeso","obesa","Otava","Osaka","nódoa","nível","névoa","nuvem","nutro","nutri","nutre","nutra","nunes","nunca","numas","nulos","nulas","nudez","noção","nozes","novos","novas","notou","notes","notem","notei","notas","notar","notam","notai","nosso","nossa","norma","noras","nomeá","nomes","noivá","noivo","noive","noiva","noite","nodal","nobre","nitro","nisto","nisso","ninou","ninho","ninfa","nines","ninem","ninei","ninas","ninar","ninam","ninai","nicho","nexos","nevou","neves","nevem","nevei","nevas","nevar","nevam","nevai","netos","netas","neste","nesta","nesse","nessa","nesga","nervo","nenês","neném","neles","nelas","negão","negue","negro","negra","negou","negas","negar","negam","negai","nação","navio","naves","naval","nauta","natos","natas","nasço","nasça","nascê","nasci","nasce","nasal","narrá","narro","narre","narra","nariz","nardo","nanou","nanes","nanem","nanei","nanas","nanar","nanam","nanai","naipe","nafta","nadou","nades","nadem","nadei","nadas","nadar","nadam","nadai","nacos","nabos","nabla","Norte","Nobel","Neusa","Natal","mútuo","mútua","múmia","móvel","míope","mídia","médio","mágoa","máfia","musgo","museu","musco","musca","musas","murro","murou","muros","mures","murem","murei","muras","murar","muram","mural","murai","muniu","munis","munir","munia","munes","munem","mundo","multá","multo","multi","multe","multa","mulas","mujas","mujam","muito","muita","mugiu","mugis","mugir","mugia","muges","mugem","mudou","mudos","mudez","mudes","mudem","mudei","mudas","mudar","mudam","mudai","mucos","moído","moída","moías","moíam","moção","moços","moças","movia","moveu","moves","mover","movem","movei","movas","movam","mouro","moura","motos","motor","motel","moscá","mosca","morto","morte","morta","morsa","morrê","morro","morri","morre","morra","morou","morno","morna","mores","morem","morei","mordê","mordo","mordi","morde","morda","moras","morar","moram","moral","morai","montá","monto","monte","monta","monja","monge","momos","molhá","molho","molhe","molha","moles","moldá","moldo","molde","molda","molas","molar","moita","mogol","mogno","mofou","mofes","mofem","mofei","mofas","mofar","mofam","mofai","moerá","moera","moemo","moela","moeis","moeda","modos","modem","modas","moamo","moais","miúdo","miúda","mixto","mixos","mitra","mitos","misto","mista","missa","mirra","mirou","mires","mirem","mirei","miras","mirar","miram","mirai","miolo","minto","minta","minou","minis","minha","mines","minem","minei","minar","minam","minai","mimou","mimos","mimes","mimem","mimei","mimas","mimar","mimam","mimai","milho","milha","mijou","mijes","mijem","mijei","mijas","mijar","mijam","mijai","migrá","migro","migre","migra","miemo","mieis","micro","micos","miava","miará","miara","miamo","miais","miado","meças","meçam","mexia","mexeu","mexes","mexer","mexem","mexei","mexas","mexam","metro","metia","meteu","metes","meter","metem","metei","metas","metam","metal","mesmo","mesma","meses","mesas","meros","merda","mercê","meras","menus","menti","mente","menta","menos","menor","menir","meneá","melão","melro","melou","meles","melem","melei","melas","melar","melam","melai","meião","meios","meigo","meiga","meias","medrá","medro","medre","medra","medos","mediá","mediu","medis","medir","media","medes","medem","mecha","meada","maçãs","maços","maçom","maças","matou","matos","matiz","mates","matem","matei","matas","matar","matam","matai","massa","mascá","masco","masca","marés","março","marra","mares","marcá","marca","mapeá","mapas","manés","mantê","manto","manta","manso","mansa","manos","manjá","manjo","manje","manja","mania","manhã","manha","manga","maneá","mandá","mando","mande","manda","mancá","manco","manca","manas","mamão","mamãe","mamou","mames","mamem","mamei","mamas","mamar","mamam","mamai","malta","malhá","malho","malhe","malha","males","malas","major","maior","maias","magôo","magro","magra","magoá","magos","magoe","magoa","magno","magna","magma","magia","macro","macio","macia","macho","macas","Média","Mário","Morse","Minas","Milão","Miami","Mauro","Marte","Marta","Maria","Marco","Malba","lótus","lítio","lírio","líeis","líder","légua","látex","lápis","lácio","lábio","lábia","luziu","luzis","luzir","luzia","luzes","luzem","luzas","luzam","luxos","luvas","lutou","lutes","lutem","lutei","lutas","lutar","lutam","lutai","lusos","lusas","lupas","lunar","lulas","lugar","lucrá","lucro","lucre","lucra","lucas","loção","louçã","louça","louvá","louvo","louve","louva","lousa","louro","loura","louco","louca","lotou","loteá","lotes","lotem","lotei","lotas","lotar","lotam","lotai","lorde","loque","lopes","longo","longe","longa","lonas","lombo","lojas","loiro","loira","lográ","logro","logre","logra","locou","locas","locar","locam","local","locai","lobão","lobos","lobas","lição","lixão","lixou","lixes","lixem","lixei","lixas","lixar","lixam","lixai","livrá","livro","livre","livra","litro","listá","listo","liste","lista","lisos","lisas","liras","linho","linha","linfa","lindo","lince","limão","limpá","limpo","limpe","limpa","limou","limes","limem","limei","limbo","limas","limar","limam","limai","lilás","ligue","ligou","ligas","ligar","ligam","ligai","lidou","lidos","lides","lidem","lidei","lidas","lidar","lidam","lidai","licor","liceu","libra","liame","lhama","leões","levou","leves","levem","levei","levas","levar","levam","levai","letra","lesão","leste","lesse","lesou","lesma","leses","lesem","lesei","lesas","lesar","lesam","lesai","lerão","lerás","lermo","leria","leres","lerem","lerei","lerdo","lerda","leras","leram","leque","lepra","leoas","lenço","lento","lente","lenta","lenho","lenha","lenga","lendo","lenda","lemos","lemes","lemas","leito","leite","leigo","leiga","leias","leiam","legue","legou","legas","legar","legam","legal","legai","ledes","lebre","leais","laçou","laços","laças","laçar","laçam","laçai","lazer","lavrá","lavro","lavre","lavra","lavou","laves","lavem","lavei","lavas","lavar","lavam","lavai","laudo","lauda","latão","latiu","latis","latir","latim","latia","lates","latem","latas","laser","lascá","lasco","lasca","larva","largá","largo","larga","lares","lapso","lançá","lanço","lança","lance","lambê","lambo","lambi","lambe","lamba","lajes","laico","laica","lagar","ladrá","ladro","ladre","ladra","lados","lacrá","lacro","lacre","lacra","laces","lacem","lacei","labor","Lúcio","Líbia","Linux","Linus","Linda","Lenin","Lauro","Laura","Lagos","Lagoa","Lages","Labma","Klein","Kioto","Kazuo","jóias","juízo","juíza","justo","justa","jurou","juros","jures","jurem","jurei","juras","jurar","juram","jurai","juntá","junto","junte","junta","junho","junco","julho","julgá","julgo","julga","judiá","judio","judie","judia","judeu","judas","jubas","jovem","jorrá","jorro","jorre","jorra","jogue","jogou","jogos","jogas","jogar","jogam","jogai","joana","jinga","jejuá","jejuo","jejum","jejue","jejua","jeito","jegue","jecas","jazia","jazeu","jazes","jazer","jazem","jazei","jazas","jazam","jaula","jatos","jarro","jarra","jarda","jantá","janto","jante","janta","jacas","Jorge","Jobim","Jesus","Japão","Jaime","içava","içará","içara","içamo","içais","içado","içada","iterá","itero","itere","itera","istmo","isolá","isolo","isole","isola","iscas","irmãs","irmão","irmos","irias","iriam","iremo","ireis","irdes","irado","irada","invés","intuí","intuo","intui","intua","inter","instá","insto","inste","insta","inová","inovo","inove","inova","inibo","inibi","inibe","iniba","infra","inflá","inflo","infle","infla","induz","incôo","incoá","incoe","incoa","inchá","incho","inche","incha","incas","inato","inata","inalá","inalo","inale","inala","imune","impõe","impôs","impus","impor","imolá","imolo","imole","imola","imitá","imito","imite","imita","iludo","iludi","ilude","iluda","ilhou","ilhes","ilhem","ilhei","ilhas","ilhar","ilham","ilhai","ileso","ilesa","igual","igapó","ienes","idéia","idoso","idosa","ideal","idade","icemo","iceis","ibero","iates","Intel","húmus","hímen","hífen","hélio","hábil","hurra","hunos","humor","hulha","houve","hotel","horto","horta","horda","horas","honrá","honro","honre","honra","homem","hinos","hindu","hiena","hiato","herói","herdá","herdo","herde","herda","heras","havia","haver","havei","hauri","haure","haste","harém","harpa","haras","halos","hajas","hajam","Hegel","Haiti","gôdos","gíria","gênio","gêmeo","gêmea","gália","guris","guria","gumes","guizo","guisa","guiou","guies","guiem","guiei","guias","guiar","guiam","guiai","gueto","grãos","gruta","grupo","grudá","grudo","grude","gruda","gritá","grito","grite","grita","gripe","grilá","grilo","grile","grila","grifá","grifo","grife","grifa","greve","grego","grega","graça","graxo","graxa","gravá","gravo","grave","grava","graus","grato","grata","grana","grama","grafá","grafo","grafe","grafa","grade","gozou","gozos","gozes","gozem","gozei","gozas","gozar","gozam","gozai","gotas","gostá","gosto","goste","gosta","gosma","gorro","gorou","gores","gorem","gorei","gordo","gorda","goras","gorar","goram","gorai","gonzo","gongo","gomos","gomes","gomas","golpe","goleá","goles","golas","goela","gnomo","glosá","gloso","glose","glosa","globo","gleba","girou","giros","gires","girem","girei","giras","girar","giram","girai","gingá","gingo","ginga","gibão","gesto","gesta","gesso","gerou","germe","geriu","geris","gerir","geria","geres","gerem","gerei","geras","gerar","geram","geral","gerai","gente","genro","genes","gemia","gemeu","gemes","gemer","gemem","gemei","gemas","gemam","gelou","gelos","geles","gelem","gelei","gelas","gelar","gelam","gelai","geies","geiem","geias","geiam","geemo","geeis","geava","geará","geara","geamo","geais","geado","geada","gazua","gatos","gatas","gastá","gasto","gaste","gasta","gases","garôo","garôa","garça","garra","garoá","garoe","garoa","garis","garfá","garfo","garfe","garfa","garbo","ganso","ganiu","ganis","ganir","gania","ganhá","ganho","ganhe","ganha","ganes","ganem","gamão","gamos","gambá","galão","galos","galho","galgá","galgo","galga","galas","gajos","gajas","gaita","gagos","gagas","gados","gabou","gabes","gabem","gabei","gabas","gabar","gabam","gabai","Guiné","Golfo","Goiás","Gauss","Gales","exumá","exumo","exume","exuma","extra","expõe","expôs","expus","expor","expiá","expio","expie","expia","eximo","eximi","exime","exima","exilá","exilo","exile","exila","exijo","exija","exigi","exige","exibo","exibi","exibe","exiba","exato","exata","exará","exaro","exare","exara","exame","exalá","exalo","exale","exala","evocá","evoco","evoca","evitá","evito","evite","evita","evado","evadi","evade","evada","etípe","etnia","etilo","eteno","etapa","etano","esvaí","esvai","estão","estás","estou","estio","estes","estas","estar","estai","esses","essas","esqui","espiã","espiá","espio","espie","espia","escôo","escoá","escol","escoe","escoa","ervas","errou","erros","erres","errem","errei","erras","errar","erram","errai","erodo","erodi","erode","eroda","ermos","eriçá","eriço","eriça","erijo","erija","erigi","erige","erice","erguê","ergui","ergue","ergas","ergam","ereto","ereta","enviá","envio","envie","envia","entôo","então","entrá","entro","entre","entra","entoá","entoe","entoa","entes","enojá","enojo","enoje","enoja","enjôo","enjoá","enjoe","enjoa","enfiá","enfio","enfim","enfie","enfia","enchê","encho","enchi","enche","encha","emulá","emulo","emule","emula","emito","emiti","emite","emita","emaná","emano","emane","emana","elmos","elixo","elixi","elixe","elite","elevá","elevo","eleve","eleva","elejo","eleja","elegê","elegi","elege","ejetá","ejeto","ejete","ejeta","eixos","eiras","educá","educo","educa","editá","edito","edita","edema","ecoou","ecoes","ecoem","ecoei","ecoas","ecoar","ecoam","ecoai","Euler","Ester","Esopo","Emaús","Elixa","Elisa","Elias","Egito","Edite","Edgar","fútil","fúria","fôrça","fórum","fêmur","fêmea","féria","félix","fátuo","fácil","fuçou","fuças","fuçar","fuçam","fuçai","fuzis","fuzil","fusão","fusos","fusco","furão","furtá","furto","furte","furta","furou","furos","furor","furna","fures","furem","furei","furas","furar","furam","furai","funis","funil","fungá","fungo","funga","fundá","fundo","fundi","funde","funda","fumou","fumes","fumem","fumei","fumas","fumar","fumam","fumai","fulgi","fulge","fujão","fujiu","fujis","fujir","fujia","fujes","fujem","fujas","fujam","fugiu","fugis","fugir","fugia","fugaz","fugas","fuces","fucem","fucei","fruís","fruía","fruto","fruta","fruiu","fruis","fruir","fruem","fruas","fruam","frota","fritá","frito"}
	#End region
	
	Dim xa As Integer
	
	Dim ho As Boolean = true 
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
		s_random
		palavra_colocada.Add("-")
		
	End Sub
	
	Sub  s_random
		
		xa = rnd.Next(1,4)
		If xa = 4 Then
			xa = 3
		End If
		
		 Select xa
		 	Case 1
		 		palavra = lista1(rnd.Next(0,2066))	
		 	Case 2
		 		palavra = lista2(rnd.Next(0,2000))
		 	Case 3
		 		palavra = lista3(rnd.Next(0,2000))
		 End Select
		
		'MsgBox(palavra,vbOKOnly)
	End Sub
	
	Dim minutos As Integer = 0
	Dim segundos As Integer = 0
	Dim comecar As Boolean = False
	
	Sub Timer2Tick(sender As Object, e As EventArgs)
		If segundos = 60 Then
			segundos = 0
			minutos += 1
		Else 
			segundos += 1
		End If
		Me.Text = "Letra         (" & minutos.ToString & ":" & segundos.ToString & ")"
	End Sub
	
	Sub Label31Click(sender As Object, e As EventArgs)
		home.show
Me.close	
	End Sub
	
	Sub Label26Click(sender As Object, e As EventArgs)
		p_select = 0
	End Sub
	
	Sub Label27Click(sender As Object, e As EventArgs)
p_select = 1		
	End Sub
	
	Sub Label28Click(sender As Object, e As EventArgs)
		p_select = 2
	End Sub
	
	Sub Label29Click(sender As Object, e As EventArgs)
		p_select =3
	End Sub
	
	Sub Label30Click(sender As Object, e As EventArgs)
p_select = 5		
	End Sub
End Class
