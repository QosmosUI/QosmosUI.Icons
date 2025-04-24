// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCrossedBones : ComponentBase
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
		builder.AddAttribute(14, "d", "M407.406 22.53c-9.832.353-19.334 5.774-25.03 18C310.03 195.818 206.43 320.097 49.405 373.47c-59.39 20.186-15.982 92.874 47.094 47.092-53.34 55.186 19.308 97.326 42.22 42.22 60.94-146.596 186.387-265.928 332.967-332.97 50.467-23.082 7.442-85.442-40.843-40.843 28.943-35.27 1.69-67.337-23.438-66.44zm-301.094.5c-24.643.51-50.094 31.967-21.78 66.47-48.286-44.598-91.28 17.76-40.813 40.844 63.846 29.2 123.663 68.308 175.905 115.28l25.25-25.25c-44.19-52-80.892-112.838-111.875-179.343-6.013-12.905-16.282-18.214-26.688-18zm188.344 249.032l-24.344 24.344c44.515 49.72 81.008 105.93 106.344 166.875 22.91 55.108 95.56 12.968 42.22-42.217 63.075 45.78 106.485-26.876 47.093-47.063-65.995-22.43-122.55-57.414-171.314-101.938z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
