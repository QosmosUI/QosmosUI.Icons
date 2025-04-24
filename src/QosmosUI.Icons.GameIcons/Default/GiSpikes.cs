// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSpikes : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 16c-5.718 51.466-24.204 93.997-32.813 124.687-8.896 2.525-17.386 5.918-25.312 10.313-27.803-15.645-71.13-32.34-111.563-64.688 32.348 40.434 49.043 83.76 64.688 111.563-4.395 7.926-7.788 16.416-10.313 25.312C109.997 231.797 67.467 250.282 16 256c51.466 5.718 93.997 24.204 124.687 32.812 2.525 8.897 5.918 17.387 10.313 25.313-15.645 27.802-32.34 71.128-64.688 111.562 40.434-32.347 83.76-49.042 111.563-64.687 7.926 4.395 16.416 7.788 25.312 10.312 8.61 30.69 27.095 73.22 32.813 124.688 5.718-51.467 24.204-93.998 32.812-124.688 8.897-2.524 17.387-5.917 25.313-10.312 27.802 15.645 71.128 32.34 111.562 64.687-32.347-40.434-49.042-83.76-64.687-111.562 4.395-7.926 7.788-16.416 10.312-25.313 30.69-8.608 73.22-27.094 124.688-32.812-51.467-5.718-93.998-24.204-124.688-32.813-2.524-8.896-5.917-17.386-10.312-25.312 15.645-27.803 32.34-71.13 64.687-111.563-40.434 32.348-83.76 49.043-111.562 64.688-7.926-4.395-16.416-7.788-25.313-10.313C280.204 109.997 261.718 67.467 256 16zm0 180c16.57 0 31.798 6.486 42.657 17.343C309.515 224.2 316 239.43 316 256c0 16.57-6.486 31.798-17.343 42.657C287.797 309.515 272.57 316 256 316c-16.57 0-31.8-6.486-42.657-17.343C202.483 287.797 196 272.57 196 256c0-16.57 6.486-31.8 17.343-42.657C224.2 202.483 239.43 196 256 196z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
