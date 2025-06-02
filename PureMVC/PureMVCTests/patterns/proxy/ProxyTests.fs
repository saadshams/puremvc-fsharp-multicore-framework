namespace PureMVCTests.patterns.proxy

open Xunit
open PureMVC.patterns.proxy

type ProxyTests() =
    
    [<Fact>]
    member _.``Test Name Accessor``() =
        // Create a new Proxy and check the name
        let proxy = Proxy("TestProxy", None) :> PureMVC.interfaces.IProxy
        Assert.Equal("TestProxy", proxy.Name)
        
    [<Fact>]
    member _.``Test Data Accessors``() =
        // Create a new Proxy and set data
        let proxy = Proxy("colors", None) :> PureMVC.interfaces.IProxy
        let colors = [| "red"; "green"; "blue" |] :> obj
        proxy.Data <- colors

        let data = proxy.Data :?> string[]

        Assert.Equal(3, data.Length)
        Assert.Equal("red", data.[0])
        Assert.Equal("green", data.[1])
        Assert.Equal("blue", data.[2])

    [<Fact>]
    member _.``Test Constructor with Name and Data``() =
        // Create a new Proxy with name and data
        let colors = [| "red"; "green"; "blue" |] :> obj
        let proxy = Proxy("colors", Some colors) :> PureMVC.interfaces.IProxy
        let data = proxy.Data :?> string[]

        Assert.NotNull(proxy)
        Assert.Equal("colors", proxy.Name)
        Assert.Equal(3, data.Length)
        Assert.Equal("red", data.[0])
        Assert.Equal("green", data.[1])
        Assert.Equal("blue", data.[2])