// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiStreamline : ComponentBase
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
		builder.AddAttribute(14, "d", "M16 14.176c-5.915 0-10.549-2.085-10.549-4.747s4.634-4.747 10.549-4.747 10.549 2.085 10.549 4.747c0 2.662-4.634 4.747-10.549 4.747zM16 5.737c-4.491 0-9.494 1.516-9.494 3.692s5.003 3.692 9.494 3.692c4.491 0 9.494-1.516 9.494-3.692s-5.004-3.692-9.494-3.692zM16 18.396c-5.915 0-10.549-2.085-10.549-4.747v-4.22c0-0.292 0.236-0.527 0.527-0.527s0.527 0.236 0.527 0.527v4.22c0 2.176 5.003 3.692 9.494 3.692s9.494-1.516 9.494-3.692v-4.22c0-0.292 0.236-0.527 0.527-0.527s0.527 0.236 0.527 0.527v4.22c0 2.662-4.634 4.747-10.549 4.747zM16 23.143c-5.915 0-10.549-2.085-10.549-4.747v-4.747c0-0.291 0.236-0.527 0.527-0.527s0.527 0.236 0.527 0.527v4.747c0 2.176 5.003 3.692 9.494 3.692s9.494-1.517 9.494-3.692v-4.747c0-0.291 0.236-0.527 0.527-0.527s0.527 0.236 0.527 0.527v4.747c0 2.662-4.634 4.747-10.549 4.747zM16 27.89c-5.915 0-10.549-2.085-10.549-4.747v-4.747c0-0.291 0.236-0.527 0.527-0.527s0.527 0.236 0.527 0.527v4.747c0 2.176 5.003 3.692 9.494 3.692s9.494-1.517 9.494-3.692v-4.747c0-0.291 0.236-0.527 0.527-0.527s0.527 0.236 0.527 0.527v4.747c0 2.662-4.634 4.747-10.549 4.747z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
