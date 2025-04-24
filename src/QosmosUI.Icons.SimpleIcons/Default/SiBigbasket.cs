// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiBigbasket : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M11.543 12.989a3.352 3.352 0 0 0-.871-1.375 2.251 2.251 0 0 0-1.474-.503 2.276 2.276 0 0 0-1.541.536 2.953 2.953 0 0 0-.973 1.375 5.609 5.609 0 0 0-.335 1.845 5.42 5.42 0 0 0 .335 1.809c.192.548.528 1.034.973 1.407.441.339.985.516 1.541.503a2.08 2.08 0 0 0 1.945-1.072h-.002a4.92 4.92 0 0 0 .67-2.649 6.477 6.477 0 0 0-.268-1.876zM20.381.033H3.587A3.584 3.584 0 0 0 0 3.585V20.38a3.59 3.59 0 0 0 3.587 3.586h16.794c1.986 0 3.601-1.6 3.619-3.586V3.585A3.614 3.614 0 0 0 20.381.033zM10.64 3.034h1.911v5.744a3.47 3.47 0 0 0-1.911-.584v-5.16zm-.438 17.93a5.586 5.586 0 0 1-2.278-.369 3.522 3.522 0 0 1-1.174-.804 4.18 4.18 0 0 1-.335-.536l-.033-.134v.302C6.281 21.266 3.4 20.931 3.4 20.931V3.034h3.15v7.442h.034a3.675 3.675 0 0 1 1.541-1.309 4.825 4.825 0 0 1 2.079-.435 4.197 4.197 0 0 1 2.649.871 5.263 5.263 0 0 1 1.675 2.278v-.001c.372.951.565 1.963.569 2.984a8.418 8.418 0 0 1-.571 2.984 5.47 5.47 0 0 1-1.675 2.278 4.161 4.161 0 0 1-2.649.838zm9.828-3.111a5.47 5.47 0 0 1-1.675 2.278 4.173 4.173 0 0 1-2.649.838 5.587 5.587 0 0 1-2.278-.37 4.85 4.85 0 0 1-.362-.186c.444-.36.837-.778 1.168-1.245.353.127.726.189 1.101.185 2.38 0 3.15-2.502 3.15-4.484 0-1.96-.721-4.523-3.15-4.523a3.058 3.058 0 0 0-1.021.163 6.349 6.349 0 0 0-1.017-1.166c.107-.063.218-.121.331-.176a4.72 4.72 0 0 1 6.403 2.715l-.001.004c.373.951.566 1.963.571 2.984a8.409 8.409 0 0 1-.571 2.983z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
