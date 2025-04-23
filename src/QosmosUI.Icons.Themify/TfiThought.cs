// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiThought : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M11.5 10.116c3.033 0 5.5-2.269 5.5-5.058s-2.467-5.058-5.5-5.058c-1.912 0-3.693 0.938-4.684 2.431-0.705-0.399-1.496-0.608-2.316-0.608-2.481 0-4.5 1.86-4.5 4.147 0 2.286 2.019 4.146 4.5 4.146 0.186 0 0.375-0.013 0.573-0.037 0.652 0.588 1.522 0.921 2.427 0.921 1.002 0 1.929-0.387 2.592-1.070 0.488 0.125 0.951 0.186 1.408 0.186zM9.745 8.785l-0.212 0.268c-0.471 0.593-1.231 0.947-2.033 0.947-0.724 0-1.414-0.29-1.895-0.797l-0.184-0.193-0.264 0.046c-0.214 0.037-0.431 0.060-0.657 0.060-1.93 0-3.5-1.411-3.5-3.145 0-1.735 1.57-3.147 3.5-3.147 0.792 0 1.549 0.246 2.189 0.713l0.472 0.343 0.267-0.52c0.738-1.433 2.336-2.36 4.072-2.36 2.481 0 4.5 1.82 4.5 4.059 0 2.237-2.019 4.058-4.5 4.058-0.453 0-0.921-0.075-1.429-0.231l-0.326-0.101zM11.5 10.5c-1.103 0-2 0.897-2 2s0.897 2 2 2 2-0.897 2-2-0.897-2-2-2zM11.5 13.5c-0.551 0-1-0.448-1-1s0.449-1 1-1 1 0.448 1 1-0.449 1-1 1zM15.25 14c-0.689 0-1.25 0.561-1.25 1.25s0.561 1.25 1.25 1.25 1.25-0.561 1.25-1.25-0.561-1.25-1.25-1.25zM15 15.25c0-0.138 0.112-0.25 0.25-0.25s0.25 0.112 0.25 0.25c0 0.275-0.5 0.275-0.5 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
