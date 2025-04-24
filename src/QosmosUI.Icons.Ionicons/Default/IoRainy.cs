// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoRainy : ComponentBase
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
		builder.AddAttribute(14, "d", "M456.26,139.37c-16.77-16.73-39.17-28.41-65.17-34a16,16,0,0,1-11.19-9,142.24,142.24,0,0,0-42.19-53.21C314.48,25.39,286.23,16,256,16a140.24,140.24,0,0,0-93.5,35.32c-24.2,21.56-40.91,51.34-48.43,85.83a16.05,16.05,0,0,1-11.72,12.18c-25,6.3-35.71,12.54-49.21,24.56C34,190.93,24,214.14,24,240.8c0,30.55,11.23,55.64,32.47,72.56C75.08,328.17,100.5,336,130,336H364c33.2,0,64.11-11.46,87-32.28,23.84-21.65,37-51.67,37-84.52C488,187.71,477,160.11,456.26,139.37Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M112,448a16,16,0,0,1-13.3-24.88l32-48a16,16,0,0,1,26.62,17.76l-32,48A16,16,0,0,1,112,448Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M160,496a16,16,0,0,1-13.29-24.88l64-96a16,16,0,0,1,26.62,17.76l-64,96A16,16,0,0,1,160,496Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M272,448a16,16,0,0,1-13.3-24.88l32-48a16,16,0,0,1,26.62,17.76l-32,48A16,16,0,0,1,272,448Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M320,496a16,16,0,0,1-13.3-24.88l64-96a16,16,0,0,1,26.62,17.76l-64,96A16,16,0,0,1,320,496Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
