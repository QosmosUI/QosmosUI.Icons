// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiMarsPathfinder : ComponentBase
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
		builder.AddAttribute(14, "d", "M304 25c-9.496 0-17.002 7.504-17.002 17S294.504 59.002 304 59.002c9.496 0 17.002-7.506 17.002-17.002 0-9.496-7.506-17-17.002-17zm-9 50.809V201h-95.377l-13.314 79.885L256 294.822l69.691-13.937L313 204.738V75.808A34.63 34.63 0 0 1 304 77a34.63 34.63 0 0 1-9-1.191zM228.2 137l-38.557 46H277v-46zM55 179.402v139.405l-14.621 13.209 22.738 23.492 164.969-5.906-3.014-29.946-15.199-15.705-35.639-7.127-8.543-1.709 4.266-25.597-42.064-16.569L73 302.543v-123.14zm128.07 11.438l-23.379 27.892 17.844 5.323zM329.123 192l5.342 32.055 17.844-5.323c-5.456-6.278-8.806-10.732-23.186-26.732zm54.984 60.95l-42.064 16.568 4.266 25.597-44.182 8.836-15.2 15.705-3.013 29.946 164.969 5.906 22.738-23.492zm-265.744 28.687l48 48-12.726 12.726-48-48zm275.274 0l12.726 12.726-48 48-12.726-12.726zm-240.453 88.119l-20.323.396-24.914 49.83L96 416l-32 32 48 16 32-32-18.805-6.268zm205.906.547l27.715 55.43L368 432l32 32 48-16-32-32-11.947 3.982-24.473-48.945z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
