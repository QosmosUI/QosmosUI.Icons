// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiDumbbell : ComponentBase
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
		builder.AddAttribute(14, "id", "Dumbbell");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M21.435,11.5h-.38V8.12a1.626,1.626,0,0,0-1.62-1.62h-.63V6.12a1.625,1.625,0,0,0-3.25,0V11.5H8.445V6.12a1.625,1.625,0,0,0-3.25,0V6.5h-.63a1.62,1.62,0,0,0-1.62,1.62V11.5h-.38a.5.5,0,1,0,0,1h.38v3.37a1.622,1.622,0,0,0,1.62,1.63H5.2v.37a1.625,1.625,0,1,0,3.25,0V12.5h7.11v5.37a1.625,1.625,0,1,0,3.25,0V17.5h.63a1.628,1.628,0,0,0,1.62-1.63V12.5h.38a.5.5,0,1,0,0-1ZM5.2,16.5h-.63a.625.625,0,0,1-.62-.63V8.12a.623.623,0,0,1,.62-.62H5.2Zm2.25,1.37a.634.634,0,0,1-.63.63.625.625,0,0,1-.62-.63V6.12a.623.623,0,0,1,.62-.62.632.632,0,0,1,.63.62Zm10.36,0a.625.625,0,1,1-1.25,0V6.12a.625.625,0,0,1,1.25,0Zm2.25-2a.625.625,0,0,1-.62.63h-.63v-9h.63a.623.623,0,0,1,.62.62Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
