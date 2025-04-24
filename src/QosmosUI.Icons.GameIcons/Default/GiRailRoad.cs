// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRailRoad : ComponentBase
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
		builder.AddAttribute(14, "d", "M198 89L29.58 487h59.77L211.8 89H198zm102.2 0l122.4 398h59.8L314 89h-13.8zm-79.4 32l-3.1 10h76.6l-3.1-10h-70.4zm-79.9 36l-4.4 14h7.2l5.9-14h-8.7zm68.8 0l-4.3 14h101.2l-4.3-14h-92.6zm152.7 0l5.9 14h7.8l-4.4-14h-9.3zm-251.7 50l-6.1 18h16.3l7.6-18h-17.8zm83.6 0l-5.5 18h134.4l-5.5-18H194.3zm189.2 0l7.6 18h16.5l-5.9-18h-18.2zM74.88 269l-7.1 26h23.47l10.95-26H74.88zm100.32 0l-8 26h177.6l-8-26H175.2zm234.6 0l11 26h23.4l-7.1-26h-27.3zM43.03 345l-7.5 30h21.88l12.69-30H43.03zm108.87 0l-9.3 30h226.8l-9.3-30H151.9zm290 0l12.7 30h21.9l-7.5-30h-27.1zM19 441v24.8L29.49 441H19zm103.3 0l-14.2 46h295.8l-14.2-46H122.3zm360.2 0l10.5 24.8V441h-10.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
