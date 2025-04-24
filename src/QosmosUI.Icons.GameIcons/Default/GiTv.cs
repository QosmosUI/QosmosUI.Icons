// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTv : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M132.992 48.756l-9.984 14.976 77.287 51.524c4.32-4.192 9.542-8.012 15.703-11.162l-83.006-55.338zm246.016 0l-83.006 55.338c6.16 3.15 11.383 6.97 15.703 11.162l77.287-51.524-9.984-14.976zM256 113.244c-22 0-35.334 7.06-43.637 15.363-4.703 4.704-7.58 9.97-9.316 14.637h105.906c-1.736-4.668-4.613-9.933-9.316-14.637-8.303-8.303-21.637-15.363-43.637-15.363zm-191.936 48c-5.044 0-11.106 2.784-15.697 7.37-4.59 4.584-7.367 10.63-7.367 15.63v279h430V184.2c.026-5.457-2.764-11.393-7.227-15.87-4.463-4.477-10.346-7.086-14.826-7.086H64.064zm30.295 23h257.745c10.374 0 20.79 6.818 26.776 16H112c-16 0-32 16-32 32v160c25.924-162.54 145.877-185.697 299.016-191.795 3.106 4.836 4.984 10.315 4.984 15.794v192c0 16-16 32-33.88 32H95.35c-15.35 0-31.35-16-31.35-32v-192c0-16 16-32 30.36-32zm328.663 7c13.7 0 25 11.3 25 25s-11.3 25-25 25-25-11.3-25-25 11.3-25 25-25zm-23.023 144h48v18h-48v-18zm0 32h48v18h-48v-18zm0 32h48v18h-48v-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
