// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiLock : ComponentBase
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
		builder.AddAttribute(15, "d", "M9.5 10.972c0 0.366-0.207 0.672-0.5 0.846v2.154h-1v-2.153c-0.294-0.174-0.5-0.48-0.5-0.847 0-0.552 0.447-1 1-1 0.551 0 1 0.447 1 1zM14.965 8.46v7.080c0 0.827-0.673 1.5-1.5 1.5h-9.989c-0.827 0-1.5-0.673-1.5-1.5v-7.080c0-0.827 0.673-1.5 1.5-1.5h0.024v-1.988c0-2.757 2.243-5 5-5s5 2.243 5 5v1.992c0.811 0.018 1.465 0.681 1.465 1.496zM4.5 6.96h8v-1.988c0-2.206-1.794-4-4-4s-4 1.794-4 4v1.988zM13.965 8.46c0-0.264-0.207-0.474-0.465-0.493v0.004h-10v-0.011h-0.024c-0.275 0-0.5 0.224-0.5 0.5v7.080c0 0.276 0.225 0.5 0.5 0.5h9.989c0.275 0 0.5-0.224 0.5-0.5v-7.080z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
