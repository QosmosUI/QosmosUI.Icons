// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBleedingEye : ComponentBase
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
		builder.AddAttribute(14, "d", "M246.344 28.938c-89.18-.037-174.996 44.27-222.656 133 21.242 38.834 45.078 64.08 54.374 100v49.968C73.3 322.043 66 329.11 66 340.312c0 9.09 11.63 18.094 21.03 18.094 9.198 0 21.597-9.677 21.595-19.25 0-11.367-7.31-17.81-11.875-27.03v-32.282c16.002-32.16 81.357-9.403 105.844 45.625v80.592c-6.364 10.477-13.625 16.953-13.625 28.875 0 17.885 11.763 24.5 23.936 24.5 11.907 0 21.594-5.66 21.594-24.5 0-9.298-7.442-16.634-13.22-31.062V325.72c15.678-36.473 54.92-20.136 71.657 31.25v74.842c-5.41 10.498-11.718 19.456-11.718 32.313 0 12.927 10.045 22.188 21.03 22.188 10.744 0 22.188-9.728 22.188-23.344 0-14.448-7.098-23.414-12.813-34.564v-84.562h-.22c15.34-65.977 52.293-101.43 68.75-52.594v59.78c-4.457 8.957-9.56 17.375-9.56 29.595 0 13.944 9.553 23.938 18.686 23.938 9.338 0 18.095-9.543 18.095-22.782 0-10.83-4.347-19.014-8.53-27.56V284.31c19.988-69.842 66.447-87.325 90.31-122.375-61.083-88.583-153.632-132.963-242.81-133zm.437 22c81.74-.606 166.08 37.776 216.126 115.906-149.813 108.407-280.244 108.6-412.969-4.938 40.834-73.15 117.62-110.38 196.844-110.97zm4.69 16.03c-44.972 0-81.407 36.468-81.407 81.438s36.435 81.406 81.406 81.406c44.97 0 81.436-36.434 81.436-81.406 0-44.97-36.467-81.437-81.437-81.437zm-.532 49.063c16.13 0 29.187 13.06 29.187 29.19 0 16.13-13.057 29.218-29.188 29.218-16.13 0-29.218-13.09-29.218-29.22s13.087-29.187 29.218-29.187z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
