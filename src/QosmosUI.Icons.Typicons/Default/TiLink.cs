// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiLink : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M18.277 6.321c-.43-.43-1.126-.43-1.556 0l-1.721 1.722-.308-.308c-1.168-1.168-3.216-1.168-4.384 0l-4.172 4.172c-.584.584-.906 1.363-.906 2.192s.322 1.608.906 2.192l.308.308-1.722 1.722c-.43.43-.43 1.126 0 1.556.215.215.496.322.778.322s.563-.107.778-.322l1.722-1.722.308.308c.584.584 1.362.906 2.192.906s1.608-.322 2.192-.906l4.172-4.172c.584-.584.906-1.362.906-2.192s-.322-1.608-.906-2.192l-.308-.308 1.722-1.722c.429-.43.429-1.126-.001-1.556zm-2.969 6.414l-4.172 4.172c-.168.168-.402.253-.636.253s-.468-.084-.636-.253l-.308-.308.722-.722c.43-.43.43-1.126 0-1.556-.215-.215-.496-.322-.778-.322s-.563.107-.778.322l-.722.722-.308-.308c-.168-.168-.261-.395-.261-.636s.093-.468.261-.636l4.172-4.172c.168-.168.394-.261.636-.261s.468.093.636.261l.308.308-.722.722c-.43.43-.43 1.126 0 1.556.215.215.496.322.778.322s.563-.107.778-.322l.722-.722.308.308c.168.168.261.395.261.636s-.093.468-.261.636z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
