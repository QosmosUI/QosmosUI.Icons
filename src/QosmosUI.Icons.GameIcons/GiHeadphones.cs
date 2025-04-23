// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHeadphones : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 51c-54.994 0-107.32 25.053-148.22 66.826l16.525 8.264C163.22 88.012 210.558 65 256 65c45.45 0 92.803 22.997 131.725 61.074l16.496-8.248C363.32 76.053 310.995 51 256 51zM95.178 131.652C54.13 180.022 27.215 246.514 25.195 321h14.022c2.225-70.647 30.325-133.29 69.992-178.906.695-.8 1.403-1.583 2.106-2.373l-16.138-8.068zm321.644 0l-16.107 8.055c.692.778 1.39 1.548 2.076 2.336C442.46 187.646 470.56 250.29 472.784 321h14.022c-2.02-74.486-28.935-140.978-69.983-189.348zM128.042 262.8c-3.485-.013-6.98 1.078-7.042 3.415V458c0 4 14 4 14 0V266c0-2.074-3.473-3.19-6.96-3.2zm255.917 0c-3.487.01-6.96 1.126-6.96 3.2v192c0 4 14 4 14 0V266.215c-.06-2.337-3.557-3.428-7.04-3.416zM103 275.73c-15.623 2.393-25.644 11.16-33.133 24.64C61.022 316.294 57 339 57 362s4.022 45.707 12.867 61.63c7.49 13.48 17.51 22.247 33.133 24.64V275.73zm306 0v172.54c15.623-2.393 25.644-11.16 33.133-24.64C450.978 407.706 455 385 455 362s-4.022-45.707-12.867-61.63c-7.49-13.48-17.51-22.247-33.133-24.64zM25 339v46h14v-46H25zm448 0v46h14v-46h-14z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
