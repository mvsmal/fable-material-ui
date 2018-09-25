module Layout.Navigation

open Global

module Mui = Fable.Helpers.MaterialUI
module MColors = Fable.MaterialUI.Colors

let navItems = [
    {
        Title = "Getting Started"
        Href = None
        Children =
            [
                { Title = "Installation"; Href = Some Page.Installation; Children = [] }
                { Title = "Usage"; Href = Some Page.Usage; Children = [] }
            ]
    }
    {
        Title = "Component demos"
        Href = None
        Children =
            [
                { Title = "App Bar"; Href = Some Page.AppBar; Children = [] }
                // { Title = "Avatars"; Href = Some Page.Avatars; Children = [] }
            ]
    }
]

let rec mapNavigation currentPage dispatch (depth: int) =
    fun item ->
        let opened =
            if not (item.Children |> List.isEmpty)
            then item.Children |> List.exists (fun i -> i.Href = Some currentPage)
            else false
        let childItems = item.Children |> List.map (mapNavigation currentPage dispatch (depth + 1))
        Layout.NavigationItem.view item depth opened currentPage childItems dispatch

let view currentPage dispatch =
    Mui.list [] (navItems |> List.map (mapNavigation currentPage dispatch 0))

