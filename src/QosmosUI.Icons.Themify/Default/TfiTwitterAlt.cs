// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiTwitterAlt : ComponentBase
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
		builder.AddAttribute(15, "d", "M15.253 5.038c0.011 0.151 0.011 0.302 0.011 0.454 0 4.605-3.506 9.912-9.913 9.912-1.974 0-3.808-0.572-5.351-1.564 0.281 0.032 0.551 0.042 0.842 0.042 1.629 0 3.127-0.55 4.325-1.488-1.532-0.032-2.815-1.036-3.257-2.417 0.215 0.032 0.431 0.054 0.656 0.054 0.314 0 0.627-0.043 0.918-0.118-1.596-0.324-2.794-1.726-2.794-3.419 0-0.011 0-0.033 0-0.043 0.464 0.258 1.003 0.42 1.575 0.442-0.938-0.626-1.553-1.694-1.553-2.901 0-0.647 0.173-1.241 0.475-1.759 1.715 2.115 4.293 3.496 7.184 3.646-0.055-0.259-0.087-0.529-0.087-0.799 0-1.919 1.554-3.483 3.484-3.483 1.003 0 1.909 0.42 2.546 1.1 0.787-0.151 1.541-0.442 2.211-0.841-0.259 0.809-0.809 1.489-1.532 1.919 0.702-0.075 1.381-0.269 2.007-0.539-0.475 0.69-1.068 1.306-1.747 1.802z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
