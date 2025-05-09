// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFruitTree : ComponentBase
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
		builder.AddAttribute(14, "d", "M217.537 82.248c-83.48-65.134-156.926-5.426-144.25 50.762-38.206 16.67-51.368 51.76-29.385 81.955-33.68 24.46-12.156 49.732 14.856 60.953C1.6 332.255 70.709 373.023 117.7 338.574c26.845 5.103 75.488-1.674 81.824-21.213 16.834-1.017 32.532-11.609 43.323-19.595 6.894 11.698 17.905 22.49 29.39 25.771 18.052 1.544 23.516-2.62 33.987-13.332 20.72 19.632 72.721 18.672 96.748 12.547 99.54 64.093 108.761-75.666 46.605-101.842 23.675-34.319 4.32-85.713-25.242-110.465 23.25-50.096-32.86-65.016-60.719-60.836-52.552-46.651-122.894-1.897-146.08 32.639zm100.356-32.295c8.836 0 16 7.164 16 16 0 8.837-7.164 16-16 16-8.837 0-16-7.163-16-16 0-8.836 7.163-16 16-16zm76.488 27.238c8.836 0 16 7.164 16 16 0 8.837-7.164 16-16 16-8.837 0-16-7.163-16-16 0-8.836 7.163-16 16-16zM144 80c8.837 0 16 7.163 16 16s-7.163 16-16 16-16-7.163-16-16 7.163-16 16-16zm182.781 28.334c8.837 0 16 7.163 16 16s-7.163 16-16 16c-8.836 0-16-7.163-16-16s7.164-16 16-16zM208 112c8.837 0 16 7.163 16 16s-7.163 16-16 16-16-7.163-16-16 7.163-16 16-16zm56.273 27.523c8.837 0 16 7.164 16 16 0 8.837-7.163 16-16 16-8.836 0-16-7.163-16-16 0-8.836 7.164-16 16-16zM400 144c8.837 0 16 7.163 16 16s-7.163 16-16 16-16-7.163-16-16 7.163-16 16-16zm-298.488 26.38c8.836 0 16 7.164 16 16 0 8.837-7.164 16-16 16-8.837 0-16-7.163-16-16 0-8.836 7.163-16 16-16zm201.478 25.286c8.837 0 16 7.163 16 16s-7.163 16-16 16c-8.836 0-16-7.163-16-16s7.164-16 16-16zm-82.883 18.654c8.837 0 16 7.164 16 16 0 8.837-7.163 16-16 16-8.836 0-16-7.163-16-16 0-8.836 7.164-16 16-16zM388 208c8.837 0 16 7.163 16 16s-7.163 16-16 16-16-7.163-16-16 7.163-16 16-16zM81.518 218.578c8.836 0 16 7.164 16 16 0 8.837-7.164 16-16 16-8.837 0-16-7.163-16-16 0-8.836 7.163-16 16-16zM160 256c8.837 0 16 7.163 16 16s-7.163 16-16 16-16-7.163-16-16 7.163-16 16-16zm215.666 9.832c8.837 0 16 7.163 16 16s-7.163 16-16 16-16-7.163-16-16 7.163-16 16-16zM288 272c8.837 0 16 7.163 16 16s-7.163 16-16 16-16-7.163-16-16 7.163-16 16-16zm163.145 11.62c8.836 0 16 7.163 16 16 0 8.836-7.164 16-16 16-8.837 0-16-7.164-16-16 0-8.837 7.163-16 16-16zM69.477 302.51c8.836 0 16 7.163 16 16 0 8.836-7.164 16-16 16-8.837 0-16-7.164-16-16 0-8.837 7.163-16 16-16zm169.132 20.365a95.897 95.897 0 0 1-8.998 5.145c3.227 45.323 7.804 94.725-4.27 141.579-43.714 9.777-62.016 11.311-96.121 25.81l255.266-.305c-26.615-14.755-55.638-20.352-101.285-27.251-11.433-39.645-10.039-84.572-6.59-125.457-14.453-1.194-29.356-10.074-38.002-19.521z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
