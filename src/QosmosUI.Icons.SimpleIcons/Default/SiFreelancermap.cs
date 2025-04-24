// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFreelancermap : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 0C5.3723 0 0 5.3723 0 12s5.3723 12 12 12l-.0115-1.3962H12c5.857 0 10.6038-4.7469 10.6038-10.6038H24c0-6.6277-5.3723-12-12-12m0 21.2054c-5.0838 0-9.2054-4.1216-9.2054-9.2054S6.9162 2.7923 12 2.7923s9.2054 4.1215 9.2054 9.2054S17.0838 21.203 12 21.203zm6.3254-4.597c3.577-5.0492.173-10.2115-2.8639-11.6146-3.6092.5747-6.8607 3.9254-7.2323 7.9108 2.8177 4.8162 8.5039 4.223 10.0985 3.7039m-9.9115-1.4493c.2653 1.6362.7246 3.247 1.703 4.4377 3.4246.8839 6.45-.7823 7.9431-2.6423-3.15 1.463-6.6623.623-9.6438-1.7954M4.7054 9.0715c-1.897 4.9939 1.3246 9.1431 4.6754 10.3039-1.0754-1.3108-1.8531-3.1639-2.0516-4.9985-1.4307-1.4307-2.4115-3.2492-2.6261-5.3054M14.31 4.53c-3.09-1.0062-6.0508.1915-7.7423 1.7954.0438 2.0746.3761 3.6946.9092 5.07.7316-3.48 3.5516-6.3416 6.8331-6.863");
		builder.CloseElement();
		builder.CloseElement();
    }
}
