// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiVideoCamera : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.991 6.75v-2.25c0-0.827-0.678-1.5-1.512-1.5h-7.479v-0.5c0-0.276 0.225-0.5 0.5-0.5h5.541v-1h-5.541c-0.827 0-1.5 0.673-1.5 1.5v0.5h-1.488c-0.834 0-1.512 0.673-1.512 1.5v2.001c0 0.827 0.678 1.5 1.512 1.5h0.504v5.499c0 0.827 0.673 1.5 1.5 1.5h7.964c0.834 0 1.512-0.673 1.512-1.5v-2.251l4.008 2.783v-10.065l-4.009 2.783zM16 12.121l-4.009-2.783v4.162c0 0.276-0.229 0.5-0.512 0.5h-7.963c-0.275 0-0.5-0.224-0.5-0.5v-6.499h-1.504c-0.283 0-0.512-0.224-0.512-0.5v-2.001c0-0.276 0.229-0.5 0.512-0.5h9.968c0.282 0 0.512 0.224 0.512 0.5v4.163l4.008-2.784v6.242z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
