Imports GroupDocs
Imports GroupDocs.Viewer

Public Class Heroes_Avian


    Public Shared HeroesOneNote As Viewer

    Private Sub Heroes_Avian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HeroesOneNote = New Viewer("https://onedrive.live.com/view.aspx?resid=6413C7A2DDE082EB%21268&id=documents&wd=target%28Books%2FMark%20Wills%20_%20Derek%20Delvin%2FMark%20Wills%2FMW.one%7C24DB5412-0855-404E-ABDB-3BFCDEAC1DDF%2FHeroes%7CA9D3A603-E870-422F-B543-00F4AA395250%2F%29onenote:https://d.docs.live.net/6413c7a2dde082eb/Documents/Javan/Books/Mark%20Wills%20_%20Derek%20Delvin/Mark%20Wills/MW.one#Heroes&section-id={24DB5412-0855-404E-ABDB-3BFCDEAC1DDF}&page-id={A9D3A603-E870-422F-B543-00F4AA395250}&end")
        Dim viewOptions = New Options.PdfViewOptions()

        HeroesOneNote.View(viewOptions)

    End Sub
End Class
