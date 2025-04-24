// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiPoolTableCorner : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M25 25v78h238V25H25zm256 0v78h.2c-5.9 12.4-9.2 26.3-9.2 41 0 52.9 43.1 96 96 96 14.7 0 28.6-3.3 41-9.2v.2h78V25H281zm87 41.02c43.2 0 78 34.78 78 77.98s-34.8 78-78 78-78-34.8-78-78 34.8-77.99 78-77.98zM25 121v30h195.3l30-30H25zm384 128v238h78V249h-78zm-18 12.7l-30 30V487h30V261.7zM252.5 265a51.5 51.5 0 0 0-51.5 51.5 51.5 51.5 0 0 0 51.5 51.5 51.5 51.5 0 0 0 51.5-51.5 51.5 51.5 0 0 0-51.5-51.5zm-68.7 111.7L160 416l43.6 24.3 20.9-41-40.7-22.6zm-33.1 54.7L117.1 487h62.7l15.6-30.6-44.7-25z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
