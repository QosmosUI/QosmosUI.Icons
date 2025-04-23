// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons;

public class DiGitMerge : ComponentBase
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
		builder.AddAttribute(14, "d", "M23.308 14.459c-1.36 0-2.53 0.751-3.158 1.853-0.164-0.012-0.325-0.026-0.496-0.026-3.742 0-7.292-2.85-8.588-6.379 0.779-0.67 1.279-1.651 1.279-2.757 0-2.017-1.637-3.654-3.654-3.654s-3.654 1.637-3.654 3.654c0 1.348 0.738 2.514 1.827 3.148v11.975c-1.089 0.633-1.827 1.799-1.827 3.147 0 2.016 1.637 3.654 3.654 3.654s3.654-1.638 3.654-3.654c0-1.349-0.738-2.514-1.827-3.147v-6.574c2.403 2.542 5.72 4.24 9.135 4.24 0.182 0 0.332-0.012 0.496-0.018 0.632 1.097 1.802 1.845 3.158 1.845 2.016 0 3.654-1.638 3.654-3.654s-1.638-3.654-3.654-3.654zM8.692 27.248c-1.008 0-1.827-0.817-1.827-1.827 0-1.008 0.819-1.827 1.827-1.827 1.011 0 1.827 0.819 1.827 1.827 0 1.010-0.816 1.827-1.827 1.827zM8.692 8.977c-1.008 0-1.827-0.816-1.827-1.827s0.819-1.827 1.827-1.827c1.011 0 1.827 0.816 1.827 1.827s-0.816 1.827-1.827 1.827zM23.308 19.94c-1.008 0-1.827-0.817-1.827-1.827s0.819-1.827 1.827-1.827c1.010 0 1.827 0.816 1.827 1.827s-0.817 1.827-1.827 1.827z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
