// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiSocialAtCircular : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M11.844 7.5c-2.481 0-4.438 2.019-4.438 4.5s2.05 4.5 4.531 4.5c.908 0 1.799-.27 2.547-.778.228-.155.295-.466.139-.694-.155-.229-.462-.287-.691-.132-.58.396-1.258.604-1.965.604-1.93 0-3.499-1.57-3.499-3.5s1.446-3.5 3.376-3.5 3.375 1.57 3.375 3.5v.25c0 .414-.336.75-.75.75s-.75-.336-.75-.75v-1.75c0-.276-.099-.5-.375-.5-.205 0-.318.124-.396.301-.303-.188-.628-.301-1.01-.301-1.104 0-1.984.896-1.984 2s.904 2 2.008 2c.562 0 1.073-.235 1.438-.609.319.369.664.609 1.192.609.965 0 1.627-.785 1.627-1.75v-.25c0-2.481-1.894-4.5-4.375-4.5zm.125 5.5c-.551 0-1-.449-1-1s.449-1 1-1 1 .449 1 1-.449 1-1 1zM12 21c-4.963 0-9-4.037-9-9s4.037-9 9-9 9 4.037 9 9-4.037 9-9 9zm0-16c-3.859 0-7 3.141-7 7s3.141 7 7 7 7-3.141 7-7-3.141-7-7-7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
