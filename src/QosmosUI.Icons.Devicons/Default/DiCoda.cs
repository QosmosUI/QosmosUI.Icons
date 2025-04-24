// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiCoda : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M23.895 10.232l-0.419-0.362-16.81 15.685 15.699-16.646-0.42-0.364c-2.026-1.087-4.61-0.843-6.72-0.149-0.609 0.201-1.217 0.442-1.796 0.718-1.249 0.595-2.406 1.363-3.416 2.312-2.303 2.165-3.767 5.051-4.484 8.11-0.201 0.859-0.367 1.737-0.488 2.611-0.152 1.099-0.242 2.205-0.319 3.311-0.065 0.93-0.204 2.187 1.094 2.109 0.231-0.014 0.462-0.011 0.693-0.016 3.249-0.069 6.516-0.033 9.64-1.078 2.032-0.68 3.98-1.779 5.503-3.292 2.282-2.265 3.934-5.567 3.675-8.845-0.114-1.453-0.434-2.987-1.433-4.105zM26.374 5.001l0.942 0.942-17.609 16.589z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
