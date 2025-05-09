// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiMedicalCross : ComponentBase
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
		builder.AddAttribute(14, "id", "Medical_Cross");
		builder.AddAttribute(15, "data-name", "Medical Cross");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M12.943,20.93H11.057a2.388,2.388,0,0,1-2.386-2.386V15.3l-3.215.029a2.39,2.39,0,0,1-2.387-2.386V11.057A2.39,2.39,0,0,1,5.456,8.67H8.7L8.671,5.456A2.388,2.388,0,0,1,11.057,3.07h1.886a2.388,2.388,0,0,1,2.386,2.386V8.7l3.215-.03a2.39,2.39,0,0,1,2.387,2.387v1.886a2.39,2.39,0,0,1-2.387,2.386H15.3l.028,3.215A2.388,2.388,0,0,1,12.943,20.93ZM5.456,9.67a1.388,1.388,0,0,0-1.387,1.387v1.886a1.388,1.388,0,0,0,1.387,1.386H8.7a.972.972,0,0,1,.972.971v3.244a1.388,1.388,0,0,0,1.386,1.386h1.886a1.388,1.388,0,0,0,1.386-1.386V15.3a.972.972,0,0,1,.972-.971h3.243a1.388,1.388,0,0,0,1.387-1.386V11.057A1.388,1.388,0,0,0,18.544,9.67H15.3a.972.972,0,0,1-.972-.97V5.456A1.388,1.388,0,0,0,12.943,4.07H11.057A1.388,1.388,0,0,0,9.671,5.456V8.7a.972.972,0,0,1-.972.97Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
