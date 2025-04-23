// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiBeaker1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Beaker_1");
		builder.AddAttribute(15, "data-name", "Beaker 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M19.447,18.645l-.51-1.52a17.9,17.9,0,0,0-4.02-6.66,1.493,1.493,0,0,1-.42-1.04V3.065H15a.5.5,0,0,0,0-1H9a.5.5,0,0,0,0,1h.5v6.36a1.484,1.484,0,0,1-.41,1.04,17.9,17.9,0,0,0-4.02,6.66l-.52,1.52a2.5,2.5,0,0,0,2.37,3.29h10.16a2.5,2.5,0,0,0,2.37-3.29Zm-9.64-7.49a2.477,2.477,0,0,0,.69-1.73V3.065h3v6.36a2.486,2.486,0,0,0,.7,1.73,16.907,16.907,0,0,1,3.01,4.38H6.787A16.943,16.943,0,0,1,9.807,11.155Zm8.49,9.16a1.507,1.507,0,0,1-1.22.62H6.917a1.5,1.5,0,0,1-1.42-1.98l.51-1.52q.15-.45.33-.9h11.32q.18.45.33.9l.51,1.52A1.5,1.5,0,0,1,18.3,20.315Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
