// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoSnowSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M447.88,313.27l19.25-10.64-21.28-38.51L426.6,274.76a133.42,133.42,0,0,0-38.54,32.1L300,256l88.07-50.86a133.42,133.42,0,0,0,38.54,32.1l19.25,10.64,21.28-38.51-19.25-10.64a89.27,89.27,0,0,1-20.93-16L480,152.05,458,114,405,144.58a89.07,89.07,0,0,1-3.42-26.15l.41-22-44-.82-.41,22A133.62,133.62,0,0,0,366.07,167L278,217.89V116.18a133.52,133.52,0,0,0,47.06-17.33L343.9,87.5,321.19,49.81,302.35,61.16A89.5,89.5,0,0,1,278,71.27V16H234V71.27a89.5,89.5,0,0,1-24.35-10.11L190.81,49.81,168.1,87.5l18.84,11.35A133.52,133.52,0,0,0,234,116.18V217.89L145.93,167a133.62,133.62,0,0,0,8.53-49.43l-.41-22-44,.82.41,22a89.07,89.07,0,0,1-3.42,26.15L54,114l-22,38.1,53.05,30.64a89.27,89.27,0,0,1-20.93,16L44.87,209.37l21.28,38.51L85.4,237.24a133.42,133.42,0,0,0,38.54-32.1L212,256l-88.07,50.86a133.42,133.42,0,0,0-38.54-32.1L66.15,264.12,44.87,302.63l19.25,10.64a89.27,89.27,0,0,1,20.93,16L32,360l22,38.1,53.05-30.63a89.07,89.07,0,0,1,3.42,26.15l-.41,22,44,.82.41-22A133.62,133.62,0,0,0,145.93,345L234,294.11V395.82a133.52,133.52,0,0,0-47.06,17.33L168.1,424.5l22.71,37.69,18.84-11.35A89.5,89.5,0,0,1,234,440.73V496h44V440.73a89.5,89.5,0,0,1,24.35,10.11l18.84,11.35L343.9,424.5l-18.84-11.35A133.52,133.52,0,0,0,278,395.82V294.11L366.07,345a133.62,133.62,0,0,0-8.53,49.43l.41,22,44-.82-.41-22A89.07,89.07,0,0,1,405,367.42L458,398.05,480,360,427,329.31A89.27,89.27,0,0,1,447.88,313.27Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
