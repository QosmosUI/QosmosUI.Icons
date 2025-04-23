// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaYoutubeSquare : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 L 5 5 z M 7 7 L 25 7 L 25 25 L 7 25 L 7 7 z M 16 11.080078 C 16 11.080078 11.609297 11.079141 10.529297 11.369141 C 9.9292969 11.539141 9.4490625 12.009141 9.2890625 12.619141 C 8.9990625 13.709141 9 16.009766 9 16.009766 C 9 16.009766 8.9990625 18.310156 9.2890625 19.410156 C 9.4490625 20.010156 9.9292969 20.470859 10.529297 20.630859 C 11.609297 20.920859 16 20.919922 16 20.919922 C 16 20.919922 20.390703 20.920859 21.470703 20.630859 C 22.070703 20.460859 22.550938 20.010391 22.710938 19.400391 C 23.000938 18.310391 23 16.009766 23 16.009766 C 23 16.009766 23.000937 13.719141 22.710938 12.619141 C 22.550937 12.009141 22.070703 11.539141 21.470703 11.369141 C 20.390703 11.079141 16 11.080078 16 11.080078 z M 14 13.15625 L 19 16.011719 L 14 18.853516 L 14 13.15625 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
