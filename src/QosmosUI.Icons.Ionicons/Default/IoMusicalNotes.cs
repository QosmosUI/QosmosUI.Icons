// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoMusicalNotes : ComponentBase
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
		builder.AddAttribute(14, "d", "M421.84,37.37a25.86,25.86,0,0,0-22.6-4.46L199.92,86.49A32.3,32.3,0,0,0,176,118v226c0,6.74-4.36,12.56-11.11,14.83l-.12.05-52,18C92.88,383.53,80,402,80,423.91a55.54,55.54,0,0,0,23.23,45.63A54.78,54.78,0,0,0,135.34,480a55.82,55.82,0,0,0,17.75-2.93l.38-.13L175.31,469A47.84,47.84,0,0,0,208,423.91v-212c0-7.29,4.77-13.21,12.16-15.07l.21-.06L395,150.14a4,4,0,0,1,5,3.86V295.93c0,6.75-4.25,12.38-11.11,14.68l-.25.09-50.89,18.11A49.09,49.09,0,0,0,304,375.92a55.67,55.67,0,0,0,23.23,45.8,54.63,54.63,0,0,0,49.88,7.35l.36-.12L399.31,421A47.83,47.83,0,0,0,432,375.92V58A25.74,25.74,0,0,0,421.84,37.37Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
