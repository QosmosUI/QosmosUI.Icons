// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFig : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M4.543 0A4.543 4.543 0 0 0 0 4.543v14.914A4.543 4.543 0 0 0 4.543 24h14.914A4.543 4.543 0 0 0 24 19.457V4.543A4.543 4.543 0 0 0 19.457 0H4.543zm10.715 2.572h3.086a3.326 3.326 0 0 1 .656.065 3.28 3.28 0 0 1 .898.326c.093.05.181.106.268.164.087.058.172.12.252.186a3.264 3.264 0 0 1 .789.96c.05.093.098.188.139.286a3.21 3.21 0 0 1 .187.61 3.276 3.276 0 0 1 .067.66v12.343a3.276 3.276 0 0 1-.146.97 3.21 3.21 0 0 1-.108.3 3.259 3.259 0 0 1-.301.552 3.28 3.28 0 0 1-.627.694c-.08.066-.165.127-.252.185a3.242 3.242 0 0 1-.553.3 3.222 3.222 0 0 1-1.27.255h-3.085a3.326 3.326 0 0 1-.658-.065 3.242 3.242 0 0 1-2.344-1.922 3.222 3.222 0 0 1-.256-1.27V5.829a3.324 3.324 0 0 1 .393-1.555 3.221 3.221 0 0 1 1.04-1.146 3.241 3.241 0 0 1 .553-.3 3.26 3.26 0 0 1 1.272-.255z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
