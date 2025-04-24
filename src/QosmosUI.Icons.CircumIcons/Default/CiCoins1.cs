// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiCoins1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Coins_1");
		builder.AddAttribute(15, "data-name", "Coins 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M18.46,10.905a3.469,3.469,0,0,0-2.47,1.04,2.3,2.3,0,0,0-.86-1.73,2.257,2.257,0,0,0,.86-1.78,2.288,2.288,0,0,0-2.28-2.29H4.35a2.284,2.284,0,0,0-1.43,4.07,2.282,2.282,0,0,0,0,3.57,2.277,2.277,0,0,0,1.43,4.06h9.36a2.29,2.29,0,0,0,2.06-1.29,3.434,3.434,0,0,0,2.69,1.3,3.475,3.475,0,1,0,0-6.95Zm-4.75,5.94H4.35a1.28,1.28,0,1,1,0-2.56h9.36a1.28,1.28,0,1,1,0,2.56Zm0-3.56H4.35a1.285,1.285,0,1,1,0-2.57h9.36a1.285,1.285,0,0,1,0,2.57Zm0-3.57H4.35a1.285,1.285,0,1,1,0-2.57h9.36a1.285,1.285,0,0,1,0,2.57Zm4.75,7.14a2.475,2.475,0,1,1,2.48-2.48A2.477,2.477,0,0,1,18.46,16.855Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
