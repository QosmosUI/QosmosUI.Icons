// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiMusicAlt : ComponentBase
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
		builder.AddAttribute(15, "d", "M6 0.265v9.222c-0.512-0.446-1.173-0.726-1.904-0.726-1.607 0-2.914 1.308-2.914 2.914s1.307 2.914 2.914 2.914c1.57 0 2.845-1.251 2.903-2.807v0-0.006c0.001-0.034 0.010-0.066 0.010-0.102s-0.008-0.067-0.009-0.101v-6.094l9 1.761v4.666c-0.513-0.451-1.178-0.734-1.914-0.734-1.607 0-2.914 1.308-2.914 2.914s1.307 2.914 2.914 2.914c1.585 0 2.872-1.273 2.907-2.849l0.007 0.002v-11.736l-11-2.152zM4.096 13.589c-1.056 0-1.914-0.858-1.914-1.914s0.858-1.914 1.914-1.914c1.021 0 1.85 0.805 1.904 1.812v0.203c-0.054 1.008-0.883 1.813-1.904 1.813zM7 4.461v-2.982l9 1.762v2.98l-9-1.76zM14.086 16c-1.056 0-1.914-0.858-1.914-1.914s0.858-1.914 1.914-1.914 1.914 0.858 1.914 1.914-0.858 1.914-1.914 1.914z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
