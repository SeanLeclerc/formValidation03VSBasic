Public Class Form1

    Dim ficheValide
    Public enregistrement As String

    Public Structure facture
        Public clientPrenom As String
        Public clientNom As String
        Public noClient As String
        Public Adresse As String
        Public ville As String
        Public province As String
        Public codePostal As String
        Public couriel As String
        Public tel As String
        Public noProd As String
        Public marque As String
        Public modele As String
        Public annee As String
        Public couleur As String
        Public categorie As String
        Public noDeSerie As String
        Public prix As String
        Public dateDeVente As String

    End Structure

    Dim ajoute = False
    Dim laFacture As New facture
    Public FicheClient As New SortedList(Of String, facture)


    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Initialize()
    End Sub

    Public Sub Initialize()


        txtNom.Text = Nothing ' ""
        txtPrenom.Text = Nothing ' ""
        mtxtNoClient.Text = Nothing ' ""
        txtAdresse.Text = Nothing ' ""
        txtAdresse.Text = Nothing ' ""
        CboProvince.Text = Nothing ' ""
        mtxtCodePostal.Text = Nothing ' ""
        txtCourriel.Text = Nothing ' ""
        mtxtNoTel.Text = Nothing ' ""
        mtxtNoProduit.Text = Nothing ' ""
        txtMarque.Text = Nothing ' ""
        txtModele.Text = Nothing ' ""
        txtModele.Text = Nothing ' ""
        txtCouleur.Text = Nothing ' ""
        txtCategorie.Text = Nothing ' ""
        txtNoSerie.Text = Nothing ' ""
        mtxtPrix.Text = Nothing ' ""
        dtpickerDateVente.Text = Nothing ' ""
    End Sub





    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click



        'No Produit
        Dim pro = True

        If mtxtNoProduit.MaskCompleted = False Then
            mtxtNoProduit.ForeColor = Color.Red
            mtxtNoProduit.Text = "N00000"
            pro = False
        End If

        '======================================================================================

        'Marque

        Dim marque = True


        Dim pins As New List(Of String)(New String() {"Apple", "Sony", "Toshiba", "Microsoft", "Hp"})
        If pins.Contains(txtMarque.Text) = False Then
            marque = False
            txtMarque.ForeColor = Color.Red
            txtMarque.Text = "Inscrire marque"

        End If

        If txtMarque.Text = "" Then
            txtMarque.Text = "Inscrire marque"
            txtMarque.ForeColor = Color.Red
            marque = False


        End If

        '=====================================================================================

        'Model
        Dim model = True

        Dim pins2 As New List(Of String)(New String() {"MacBook Pro", "Vaio", "Tecra", "EliteBook", "Windows 10", "Mackoob Air"})
        If pins2.Contains(txtModele.Text) = False Then

            txtModele.ForeColor = Color.Red
            txtModele.Text = "Inscrire modele"
            model = False

        End If

        If txtModele.Text = "" Then
            txtModele.Text = "Inscrire modele"
            txtModele.ForeColor = Color.Red
            model = False


        End If

        '=====================================================================================

        'Date
        Dim laDate = True

        Dim pinsDate As New List(Of String)(New String() {"2015", "2016", "2017", "2018", "2019"})
        If pinsDate.Contains(mtxtAnnee.Text) = False Then

            mtxtAnnee.ForeColor = Color.Red
            mtxtAnnee.Text = "2017"
            laDate = False


        End If

        If mtxtAnnee.Text = "" Then
            mtxtAnnee.Text = "2017"
            mtxtAnnee.ForeColor = Color.Red
            laDate = False

        End If

        '=====================================================================================
        'Couleur
        Dim couleur = True

        Dim pinsCou As New List(Of String)(New String() {"Bleu", "Vert", "Rouge", "Jaune", "Rose"})
        If pinsCou.Contains(txtCouleur.Text) = False Then

            txtCouleur.ForeColor = Color.Red
            txtCouleur.Text = "Inscrire couleur"
            couleur = False


        End If

        If txtCouleur.Text = "" Then
            txtCouleur.Text = "Inscrire couleur"
            txtCouleur.ForeColor = Color.Red
            couleur = False

        End If

        '=====================================================================================

        'Categorie
        Dim cat = True

        Dim pinsCat As New List(Of String)(New String() {"Cuisine", "Salon", "Bureau", "Loisir", "Autres"})
        If pinsCat.Contains(txtCategorie.Text) = False Then

            txtCategorie.ForeColor = Color.Red
            txtCategorie.Text = "Inscrire categorie"
            cat = False


        End If

        If txtCategorie.Text = "" Then
            txtCategorie.Text = "Inscrire categorie"
            txtCategorie.ForeColor = Color.Red
            cat = False


        End If
        '=====================================================================================

        'No de serie
        Dim noSerie = True

        If txtNoSerie.Text.Length < 8 Then
            txtNoSerie.ForeColor = Color.Red
            txtNoSerie.Text = "Inscrire no de série"
            noSerie = False
        End If

        '=====================================================================================

        'Prix

        Dim prix = True
        If mtxtPrix.Mask < 8 Then
            mtxtPrix.Text = "000 000.00"
            mtxtPrix.ForeColor = Color.Red
            prix = False
        End If

        If mtxtPrix.MaskCompleted = True Then
            prix = True
        Else
            mtxtPrix.Text = "000 000.00"
            mtxtPrix.ForeColor = Color.Red
            prix = False

        End If


        '=====================================================================================
        'No de client
        Dim noClient = True

        If mtxtNoClient.MaskCompleted = False Then
            mtxtNoClient.Text = "A0000"
            mtxtNoClient.ForeColor = Color.Red
            noClient = False
        End If

        '=====================================================================================

        'Nom client
        Dim nomClient = True

        If txtNom.Text = "" = True Then
            txtNom.Text = "Inscrire nom"
            txtNom.ForeColor = Color.Red
            nomClient = False
        End If

        '=====================================================================================


        'Prenom client
        Dim prenomClient = True

        If txtPrenom.Text = "" = True Then
            txtPrenom.Text = "Inscrire Prenom"
            txtPrenom.ForeColor = Color.Red
            prenomClient = False
        End If

        '=====================================================================================

        'Adresse
        Dim adresse = True

        If txtAdresse.Text = "" = True Then
            txtAdresse.Text = "Inscrire adresse"
            txtAdresse.ForeColor = Color.Red
            adresse = False
        End If

        '=====================================================================================

        'Ville
        Dim ville = True

        If txtVille.Text = "" = True Then
            txtVille.Text = "Inscrire ville"
            txtVille.ForeColor = Color.Red
            ville = False
        End If

        '=====================================================================================

        'Code Postal
        Dim codePostal = True

        If mtxtCodePostal.MaskCompleted = False Then
            codePostal = False

            mtxtCodePostal.Text = "Inscrire Code Postal"
            mtxtCodePostal.ForeColor = Color.Red

        End If

        '=====================================================================================

        'Courriel

        Dim courriel = True
        If txtCourriel.TextLength = 1 Then

        ElseIf (txtCourriel.ToString).Contains("@") = False Then
            courriel = False

            txtCourriel.ForeColor = Color.Red
        End If

        If txtCourriel.TextLength > 60 Then
            txtCourriel.ForeColor = Color.Red
            courriel = False

        End If
        '=====================================================================================

        'Telephone 
        Dim telephone = True

        If mtxtNoTel.MaskCompleted = False Then
            mtxtNoTel.Text = "(000)000-0000"
            mtxtNoTel.ForeColor = Color.Red
            telephone = False
        End If
        '=====================================================================================

        'Apparaitre buttons
        ficheValide = pro And marque And model And laDate And couleur And cat And noSerie And prix And noClient And nomClient And prenomClient And adresse And ville And codePostal And courriel And telephone

        If ficheValide = True Then

            btnAfficherVente.Visible = True
            btnAjouterCollection.Visible = True





        End If

    End Sub





    Private Sub btnAfficherVente_Click(sender As Object, e As EventArgs) Handles btnAfficherVente.Click

        Dim stringDeLaFacturation As String

        stringDeLaFacturation = vbTab & vbTab & "Facturation" & vbCrLf &
                  "Client:" & vbTab & vbTab + txtNom.Text + ", " + txtPrenom.Text & vbCrLf &
                  "No de client:" & vbTab + mtxtNoClient.Text & vbCrLf &
                  "Adresse:" & vbTab & vbTab + txtAdresse.Text & vbCrLf &
                  "Ville:" & vbTab & vbTab + txtVille.Text & vbCrLf &
                  "Province:" & vbTab & vbTab + CboProvince.Text & vbCrLf &
                  "Code postal:" & vbTab + mtxtCodePostal.Text & vbCrLf &
                  "Courriel:" & vbTab & vbTab + txtCourriel.Text & vbCrLf &
                  "Téléphone:" & vbTab + mtxtNoTel.Text & vbCrLf & vbCrLf &
                  "==============================================" & vbCrLf & vbCrLf &
                  "No de produit:" & vbTab + mtxtNoProduit.Text & vbCrLf &
                  "Marque:" & vbTab & vbTab + txtMarque.Text & vbCrLf &
                  "Modèle:" & vbTab & vbTab + txtModele.Text & vbCrLf &
                  "Année:" & vbTab & vbTab + mtxtAnnee.Text & vbCrLf &
                  "Couleur:" & vbTab & vbTab + txtCouleur.Text & vbCrLf &
                  "Catégorie:" & vbTab + txtCategorie.Text & vbCrLf &
                  "No de série:" & vbTab + txtNoSerie.Text & vbCrLf &
                  "Prix:" & vbTab & vbTab + mtxtPrix.Text & vbCrLf &
                  "Date de vente:" & vbTab + dtpickerDateVente.Text

        txtFacturation.Text = stringDeLaFacturation




    End Sub

    Private Sub btnAjouterCollection_Click(sender As Object, e As EventArgs) Handles btnAjouterCollection.Click

        Dim rand As String = (mtxtNoClient.Text + "/" + txtNoSerie.Text)


        Dim cle As String
        Dim Factures As New facture
        cle = CStr(rand)
        laFacture.clientNom = Me.txtNom.Text
        laFacture.clientPrenom = Me.txtPrenom.Text
        laFacture.noClient = Me.mtxtNoClient.Text
        laFacture.Adresse = Me.txtAdresse.Text
        laFacture.ville = Me.txtAdresse.Text
        laFacture.province = Me.CboProvince.Text
        laFacture.codePostal = Me.mtxtCodePostal.Text
        laFacture.couriel = Me.txtCourriel.Text
        laFacture.tel = Me.mtxtNoTel.Text
        laFacture.noProd = Me.mtxtNoProduit.Text
        laFacture.marque = Me.txtMarque.Text
        laFacture.modele = Me.txtModele.Text
        laFacture.annee = Me.txtModele.Text
        laFacture.couleur = Me.txtCouleur.Text
        laFacture.categorie = Me.txtCategorie.Text
        laFacture.noDeSerie = Me.txtNoSerie.Text
        laFacture.prix = Me.mtxtPrix.Text
        laFacture.dateDeVente = Me.dtpickerDateVente.Text
        If FicheClient.ContainsKey(cle) Then
            MsgBox("ERREUR : La clé (no de client) ==> " & CStr(cle) & " <== existe déjà.")
        Else
            FicheClient.Add(cle, Factures)
            MsgBox("La fiche client ==> " & CStr(cle) & " <== a été sauvegardée.")
            ajoute = True
        End If
        Me.cboClientProduit.Items.Clear()
        For Each element In FicheClient.Keys
            Me.cboClientProduit.Items.Add(element)
        Next element
        Me.cboClientProduit.Sorted = True


        If ajoute = True Then
            btnExtrireCollection.Visible = True
            btnSupprimerCollection.Visible = True
            btnSauvegarderCollection.Visible = True



        End If
    End Sub

    Private Sub btnExtrireCollection_Click(sender As Object, e As EventArgs) Handles btnExtrireCollection.Click
        Dim cle As String
        Dim Clients As New facture

        If cboClientProduit.Text <> "" Then
            cle = CStr(cboClientProduit.Text)
            If Not FicheClient.ContainsKey(cle) Then
                MsgBox("ERREUR : La clé (no de client) ==> " & CStr(cle) & " <== n'existe pas.")
            Else
                Clients = FicheClient.Item(cle)
            End If
            txtNom.Text = laFacture.clientNom
            txtPrenom.Text = laFacture.clientPrenom
            mtxtNoClient.Text = laFacture.noClient
            txtAdresse.Text = laFacture.Adresse
            txtVille.Text = laFacture.ville
            CboProvince.Text = laFacture.province
            mtxtCodePostal.Text = laFacture.codePostal
            txtCourriel.Text = laFacture.couriel
            mtxtNoTel.Text = laFacture.tel
            mtxtNoProduit.Text = laFacture.noProd
            txtMarque.Text = laFacture.marque
            txtModele.Text = laFacture.modele
            txtModele.Text = laFacture.annee
            txtCouleur.Text = laFacture.couleur
            txtCategorie.Text = laFacture.categorie
            txtNoSerie.Text = laFacture.noDeSerie
            mtxtPrix.Text = laFacture.prix
            dtpickerDateVente.Text = laFacture.dateDeVente

        Else
            MsgBox("Sélectionner une valeur de la liste.")
        End If
    End Sub

    Private Sub btnSupprimerCollection_Click(sender As Object, e As EventArgs) Handles btnSupprimerCollection.Click
        If cboClientProduit.Text = "" Or IsNothing(cboClientProduit.Text) Then
            MsgBox("ERREUR : Sélectionner une  clé (no de client).")
            Exit Sub
        End If
        If Not FicheClient.ContainsKey(cboClientProduit.Text) Then
            MsgBox("ERREUR : La clé (no de client) ==> " & cboClientProduit.Text & " <== n'existe pas.")
        Else
            FicheClient.Remove(cboClientProduit.Text)
            MsgBox("La fiche client ==> " & CStr(cboClientProduit.Text) & " <== a été supprimée.")
            If txtNom.Text = cboClientProduit.Text Then
                Initialize()
            End If
            cboClientProduit.Items.Remove(cboClientProduit.Text)
            cboClientProduit.Text = ""
        End If
    End Sub


    Public Sub CreerChaineDelimitee()
        enregistrement = txtNom.Text & "|" &
        mtxtNoClient.Text & "|" &
        txtAdresse.Text & "|" &
        txtAdresse.Text & "|" &
        CboProvince.Text & "|" &
        mtxtCodePostal.Text & "|" &
        txtCourriel.Text & "|" &
        mtxtNoTel.Text & "|" &
        mtxtNoProduit.Text & "|" &
        txtMarque.Text & "|" &
        txtModele.Text & "|" &
        txtModele.Text & "|" &
        txtCouleur.Text & "|" &
        txtCategorie.Text & "|" &
        txtNoSerie.Text & "|" &
        mtxtPrix.Text & "|" &
        dtpickerDateVente.Text '"|" & _
    End Sub


    Private Sub btnSauvegarderCollection_Click(sender As Object, e As EventArgs) Handles btnSauvegarderCollection.Click
        'http://msdn.microsoft.com/en-us/library/microsoft.visualbasic.fileio.filesystem(v=vs.100).aspx
        AjouterDansFichierSequentiel()
    End Sub

    Private Sub AjouterDansFichierSequentiel()
        If ficheValide Then
            CreerChaineDelimitee()
            Dim fileExists As Boolean
            fileExists = My.Computer.FileSystem.FileExists("..\..\..\Devoir01.txt")
            If fileExists Then
                MsgBox("Fichier existant.")
                My.Computer.FileSystem.WriteAllText("..\..\..\Devoir01.txt",
                                                                    enregistrement & vbCrLf, True)
            Else
                MsgBox("Fichier non existant. Il sera créé.")
                My.Computer.FileSystem.WriteAllText("..\..\..\Devoir01.txt",
                                                                    enregistrement & vbCrLf, False)
            End If
        Else
            MsgBox("Fiche invalide. Non inscrite dans le fichier.")
        End If

    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Close()
    End Sub

    Private Sub btnInitialiser_Click(sender As Object, e As EventArgs) Handles btnInitialiser.Click
        Initialize()
    End Sub
End Class
