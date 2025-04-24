// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiMug1 : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Mug_1");
		builder.AddAttribute(15, "data-name", "Mug 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M18.115,5.91V4.97a1.2,1.2,0,0,0-1.2-1.2H4.265a1.2,1.2,0,0,0-1.2,1.2v9.14a11.321,11.321,0,0,0,.8,4.17A3.3,3.3,0,0,0,7,20.23h7.19a3.312,3.312,0,0,0,3.14-1.95,10.989,10.989,0,0,0,.74-3.13l1.04-.52a3.319,3.319,0,0,0,1.83-2.97V9.19A3.326,3.326,0,0,0,18.115,5.91Zm-1.73,12.01a2.3,2.3,0,0,1-2.2,1.31H7a2.312,2.312,0,0,1-2.2-1.31,10.238,10.238,0,0,1-.73-3.81V4.97a.2.2,0,0,1,.2-.2h12.65a.2.2,0,0,1,.2.2v9.14A10.238,10.238,0,0,1,16.385,17.92Zm3.55-6.26a2.287,2.287,0,0,1-1.28,2.07l-.54.27V6.93a2.316,2.316,0,0,1,1.82,2.26Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
