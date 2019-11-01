Imports React

Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim env = AssemblyRegistration.Container.Resolve(Of IReactEnvironment)()
        Dim objectModel = New With {Key .user = "React User"}
        Dim reactComponent = env.CreateComponent("ReactContent", objectModel)

        PageContent.Text = reactComponent.RenderHtml()
    End Sub
End Class