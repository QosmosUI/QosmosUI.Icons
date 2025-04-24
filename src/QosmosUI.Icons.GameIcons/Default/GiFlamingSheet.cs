// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFlamingSheet : ComponentBase
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
		builder.AddAttribute(14, "d", "M24.17 23.23C141.2 130.5 6.05 261.7 98.24 395.8c52.16 75.9 147.16 102.4 243.36 84.3C536 443.6 541.9 105.6 306.4 60.75c125.4 74.35 79.7 167.45 23.3 148.45-76.7-25.8 20.4-110.79-86.4-169.66 46.2 92.96-76.4 78.56-77.6 1.68C118.8 100 235.9 174.2 243.8 241.5c12.3 105.1-118.3 77.1-90.9-41.3 15.5-66.5-34-127.13-128.73-176.97zM427.9 168.1c63.6 104.5 30.6 218.7-28.7 263-78.8 58.8-223.4 37.1-282.7-53.8 165.6 102.2 286.6 19.3 205.1-94 8.5 47-17.8 82.6-65.3 97.5 36.2-30 46.5-96.2 2.2-200.3 91.6 139.8 203.6 100.3 169.4-12.4zm-319.4 24.1c-8.57 99.3 58.1 170.8 140.7 163.2-97.7 68-206.53-47.1-140.7-163.2zm291.8 96c-19.6 0-35.4 15.9-35.4 35.5s15.8 35.4 35.4 35.4c19.6 0 35.5-15.8 35.5-35.4-.4-20.3-20.2-35-35.5-35.5zm-21.2 89.5c-10.7 0-19.4 8.8-19.4 19.5 0 10.8 8.7 19.5 19.4 19.5 10.8 0 19.5-8.7 19.5-19.5 0-10.7-8.7-19.5-19.5-19.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
