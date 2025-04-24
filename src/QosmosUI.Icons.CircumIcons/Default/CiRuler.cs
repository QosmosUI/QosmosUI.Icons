// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiRuler : ComponentBase
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
		builder.AddAttribute(14, "id", "Ruler");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M9.479,3.5a1.5,1.5,0,0,0-2.12,0L3.5,7.35a1.516,1.516,0,0,0-.44,1.06A1.5,1.5,0,0,0,3.5,9.47L14.519,20.5a1.509,1.509,0,0,0,2.13,0l3.85-3.86a1.491,1.491,0,0,0,0-2.12ZM8.359,7.08a.5.5,0,0,0,0,.71.524.524,0,0,0,.71,0c.55-.56,1.09-1.1,1.65-1.64l1.25,1.25-.9.9a.483.483,0,0,0,0,.7.5.5,0,0,0,.71,0c.29-.3.6-.6.9-.89l1.25,1.25-1.64,1.65a.495.495,0,0,0,.7.7c.56-.55,1.1-1.09,1.65-1.64l1.25,1.25-.9.9a.524.524,0,0,0-.14.36.5.5,0,0,0,.14.35.513.513,0,0,0,.71,0l.9-.9,1.26,1.26-1.65,1.64a.5.5,0,0,0,.71.71c.55-.56,1.09-1.1,1.65-1.64l1.23,1.23a.5.5,0,0,1,0,.7l-3.86,3.86a.5.5,0,0,1-.71,0L4.209,8.77a.491.491,0,0,1-.15-.36.485.485,0,0,1,.15-.35L8.069,4.2a.508.508,0,0,1,.7,0l1.24,1.24Z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M18.939,12.96l-.04-.04c.01,0,.01,0,.02.01S18.939,12.95,18.939,12.96Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
