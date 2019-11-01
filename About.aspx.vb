Imports React

Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Dim env = AssemblyRegistration.Container.Resolve(Of IReactEnvironment)()
        Dim env = React.ReactEnvironment.Current
        Dim objectModel = New With {Key .user = "React User"}
        Dim reactComponent = env.CreateComponent("PageContent", objectModel)

        PageContent.Text = reactComponent.RenderHtml()
    End Sub
End Class