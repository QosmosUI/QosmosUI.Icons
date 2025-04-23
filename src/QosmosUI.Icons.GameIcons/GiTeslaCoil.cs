// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiTeslaCoil : ComponentBase
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
		builder.AddAttribute(14, "d", "M157.78 18.72l-71.686.56-30 93.157 89.094 38.72-31 120.874 69.562-133.467-79.094-39L157.78 18.72zm197.532 0l76.47 131.093-86.094 21.437 80.062 184.875-36.813-162.906 83.25-18.876L412.97 19.28l-57.658-.56zm-99.937.5C223.01 19.22 197 45.26 197 77.624s26.01 58.406 58.375 58.406c32.365 0 58.406-26.04 58.406-58.405S287.74 19.22 255.376 19.22zM236.22 152.28v14.626h38.31V152.28c-6.13 1.58-12.54 2.44-19.155 2.44-6.614 0-13.025-.86-19.156-2.44zm-24.376 33.314c-17.463 0-22.313 8.166-22.344 14.625-.03 6.457 4.61 14.53 22.344 14.53h93.75c6.046 0 9.463-1.904 11.875-4.5 2.41-2.596 3.77-6.313 3.78-10.125.01-3.812-1.327-7.483-3.72-10.063-2.39-2.58-5.807-4.468-11.936-4.468h-93.75zm24.375 47.844v12.656h38.31v-12.656h-38.31zm-68.095 31.343c-6.13 0-9.515 1.89-11.906 4.47-2.393 2.58-3.73 6.25-3.72 10.063.01 3.81 1.37 7.528 3.78 10.125 2.413 2.596 5.798 4.5 11.845 4.5h167.78c17.734 0 22.376-8.073 22.345-14.532-.03-6.458-4.88-14.625-22.344-14.625h-167.78zm68.094 47.845v14.688h38.31v-14.688h-38.31zM131.53 346c-6.128 0-9.514 1.92-11.905 4.5-2.39 2.58-3.73 6.25-3.72 10.063.012 3.81 1.37 7.497 3.782 10.093s5.798 4.5 11.844 4.5H372.5c17.733 0 22.375-8.073 22.344-14.53-.032-6.46-4.882-14.626-22.344-14.626H131.53zm104.69 47.844v15.125h38.31v-15.126h-38.31zm-139 33.812c-6.13 0-9.516 1.92-11.907 4.5-2.392 2.58-3.73 6.25-3.72 10.063.01 3.81 1.37 7.496 3.782 10.092 2.412 2.597 5.797 4.5 11.844 4.5H406.81c17.733 0 22.376-8.072 22.344-14.53-.03-6.46-4.88-14.626-22.344-14.626H97.22zm139 47.844v18.53h38.31V475.5h-38.31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
